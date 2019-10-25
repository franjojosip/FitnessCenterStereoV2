import BaseForm from '../../../common/components/BaseForm';


export default class BodyPartTypeForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["name", "abbreviation"];
        const placeholder = {
            "name": "Enter name",
            "abbreviation": "Enter abbreviation"
        };
        const labels = {
            "name": "Name",
            "abbreviation": "Abbreviation"
        };
        const rules = {
            "name": 'required|string|between:3, 25',
            "abbreviation": 'required|string|between:3, 3'
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}
