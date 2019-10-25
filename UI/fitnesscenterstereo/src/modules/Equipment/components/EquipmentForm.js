import BaseForm from '../../../common/components/BaseForm';

export default class EquipmentForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["name"];
        const placeholder = {
            "name": "Enter name"
        };
        const labels = {
            "name": "Name"
        };
        const rules = {
            "name": 'required|string|between:3, 25'
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}