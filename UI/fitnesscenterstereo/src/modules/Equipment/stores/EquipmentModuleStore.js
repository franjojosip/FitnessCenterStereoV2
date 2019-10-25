import EquipmentDataStore from './EquipmentDataStore';

export default class EquipmentModuleStore {
    constructor(rootStore) {
        this.rootStore = rootStore;
        this.equipmentDataStore = new EquipmentDataStore();
    }
}