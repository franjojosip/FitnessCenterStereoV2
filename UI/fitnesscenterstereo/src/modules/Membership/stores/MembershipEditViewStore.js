import { observable, action, runInAction } from 'mobx';
import toaster from 'toasted-notes';
import MembershipForm from '../components/MembershipForm';

class MembershipEditViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.membershipModuleStore.membershipDataStore;
        const id = rootStore.routerStore.routerState.params.id;
        if (id != null) {
            this.dataStore.get(id).then(({price}) => {
                runInAction(() => {
                    this.form = new MembershipForm({
                        values: { price },
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
            this.form = new MembershipForm({
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

}

export default MembershipEditViewStore;
