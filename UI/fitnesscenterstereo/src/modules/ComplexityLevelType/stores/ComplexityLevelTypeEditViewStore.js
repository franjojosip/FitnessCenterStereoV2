import { observable, action, runInAction } from 'mobx';
import toaster from 'toasted-notes';
import ComplexityLevelTypeForm from '../components/ComplexityLevelTypeForm';

class ComplexityLevelTypeEditViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.complexityLevelTypeModuleStore.complexityLevelTypeDataStore;
        const id = rootStore.routerStore.routerState.params.id;
        if (id != null) {
            this.dataStore.get(id).then(({ name, abbreviation }) => {
                runInAction(() => {
                    this.form = new ComplexityLevelTypeForm({
                        values: { name, abbreviation },
                        hooks: {
                            onSuccess: (form) => {
                                console.log("onSuccess: ", form.values());
                                this.onUpdate(id);
                                this.onCreate();

                            },
                            onError: (form) => {
                                console.log("onError: ", form.values());
                            }
                        }
                    });
                    this.isLoading = false;
                });
            }
            );
        } else {
            this.form = new ComplexityLevelTypeForm({
                hooks: {
                    onSuccess: (form) => {
                        console.log("onSuccess: ", form.values());

                    },
                    onError: (form) => {
                        console.log("onError: ", form.values());
                    }
                }
            });
            this.isLoading = false;
        }

    }

    @observable form;
    @observable isLoading = true;
    @observable errorMessage = "";

    initializeForm() {
        const values = {
            "name": this.item.name,
            "abbreviation": this.item.abbreviation
        };
        const hooks = {
            onSuccess(form) {
                console.log('Form Values!', form.values());
                toaster.notify('Form is valid!', {
                    duration: 2000
                })
                this.onUpdate();
            },
            onError(form) {
                console.log('All form errors', form.errors());
                toaster.notify('Form is invalid!', {
                    duration: 2000
                })
            }
        }

        this.form = new ComplexityLevelTypeForm({ values, hooks });
        this.isLoading = false;
    }

    @action.bound async get() {
        // this.isLoading = true;
        // this.item = await (this.dataStore.get(this.itemToUpdateId));
    }

    @action.bound async onUpdate(id) {
        try {
            this.response = await (this.dataStore.update(this.form.values(), id));
            this.response ?
                toaster.notify('Update successful!', { duration: 2000 })
                :
                toaster.notify('Update failed!', { duration: 2000 })
        } catch (error) {
            console.log(error);
        }
    }

    @action.bound async onCreate() {
        try {
            this.response = await (this.dataStore.create(this.form.values()));
            this.response ?
                toaster.notify('Create successful!', { duration: 2000 })
                :
                toaster.notify('Create failed!', { duration: 2000 })
        } catch (error) {
            console.log(error);
        }
    }

    @action.bound onClear() {
        this.itemName = "";
        this.itemAbrv = "";
    }

    @action.bound onReset() {
        this.itemName = this.item.name;
        this.itemAbrv = this.item.abbreviation;
    }

    @action.bound onNameChange(name) {
        this.itemName = name;
    }

    @action.bound onAbrvChange(abrv) {
        this.itemAbrv = abrv;
    }
}

export default ComplexityLevelTypeEditViewStore;
