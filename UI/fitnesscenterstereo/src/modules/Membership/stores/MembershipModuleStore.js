import MembershipDataStore from './MembershipDataStore';


export default class MembershipModuleStore {
    constructor(rootStore) {
        this.rootStore=rootStore;
        this.membershipDataStore=new MembershipDataStore();
 }
  
}