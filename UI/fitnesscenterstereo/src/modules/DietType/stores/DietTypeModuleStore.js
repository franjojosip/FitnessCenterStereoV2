import DietTypeDataStore from './DietTypeDataStore';

export default class DietTypeModuleStore{
    constructor(rootStore){
        this.rootStore = rootStore;
        this.dietTypeDataStore = new DietTypeDataStore();
    }



}