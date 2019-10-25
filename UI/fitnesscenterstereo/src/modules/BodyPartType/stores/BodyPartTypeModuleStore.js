import BodyPartTypeDataStore from './BodyPartTypeDataStore';


export default class BodyPartTypeModuleStore {
    constructor(rootStore) {
        this.rootStore=rootStore;
        this.bodyPartTypeDataStore=new BodyPartTypeDataStore();
 }
  



}