import { observable, action, runInAction } from 'mobx';
import toaster from 'toasted-notes';
import TrainerForm from '../components/TrainerForm';

class TrainerEditViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.trainerModuleStore.trainerDataStore;
        const id = rootStore.routerStore.routerState.params.id;
        if (id != null) {
            this.dataStore.get(id).then(({ firstname, lastName, hiredAt }) => {
                runInAction(() => {
                    this.form = new TrainerForm({
                        values: { firstname, lastName, hiredAt },
                        hooks: {
                            onSuccess: (form) => {
                                console.log("onSuccess: ", form.values());
                                this.onUpdate(id);
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
            this.form = new TrainerForm({
                hooks: {
                    onSuccess: (form) => {
                        console.log("onSuccess: ", form.values());
                        this.onCreate();
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

    async onUpdate(id) {
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
}

export default TrainerEditViewStore;