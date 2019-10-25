import BaseForm from '../../../common/components/BaseForm';

export default class ComplexityLevelTypeForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["name", "abbreviation","ingridients"];
        const placeholder = {
            "name": "Enter name",
            "abbreviation": "Enter abbreviation",
            "ingridients" : "Enter ingredients"
        };
        const labels = {
            "name": "Name",
            "abbreviation": "Abbreviation",
            "ingridients": "Ingredients"
        };
        const rules = {
            "name": 'required|string|between:3, 25',
            "abbreviation": 'required|string|between:3, 3',
            "ingridients": 'required|string|between:5, 50'
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}