import StepDataStore from './StepDataStore';

export default class DietTypeModuleStore{
    constructor(rootStore){
        this.rootStore = rootStore;
        this.stepDataStore = new StepDataStore();
    }



}