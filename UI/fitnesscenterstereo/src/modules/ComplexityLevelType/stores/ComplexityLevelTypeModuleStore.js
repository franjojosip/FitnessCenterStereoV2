import ComplextiyLevelTypeDataStore from './ComplexityLevelTypeDataStore';

export default class ComplexityLevelTypeModuleStore {
    constructor(rootStore) {
        this.rootStore = rootStore;
        this.complexityLevelTypeDataStore = new ComplextiyLevelTypeDataStore();
    }
}