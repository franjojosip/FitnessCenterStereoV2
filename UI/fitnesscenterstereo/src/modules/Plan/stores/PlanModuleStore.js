import PlanDataStore from './PlanDataStore';


export default class PlanModuleStore {
    constructor(rootStore) {
        this.rootStore=rootStore;
        this.planDataStore=new PlanDataStore();
 }
  
}