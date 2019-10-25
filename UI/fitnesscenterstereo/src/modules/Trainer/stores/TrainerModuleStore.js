import TrainerDataStore from './TrainerDataStore';

export default class TrainerModuleStore {
    constructor(rootStore) {
        this.rootStore = rootStore;
        this.trainerDataStore = new TrainerDataStore();
    }
}