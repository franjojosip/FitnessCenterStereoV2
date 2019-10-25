import BaseForm from '../../../common/components/BaseForm';

export default class StepForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["name", "abbreviation","description","exercisesid"];
        const placeholder = {
            "name": "Enter name",
            "abbreviation": "Enter abbreviation",
            "description": "Enter description",
            "exercisesid": "Enter exercises ID"
        };
        const labels = {
            "name": "Name",
            "abbreviation": "Abbreviation",
            "description": "Description",
            "exercisesid": "Exercises ID"
        };
        const rules = {
            "name": 'required|string|between:3, 25',
            "abbreviation": 'required|string|between:3, 3',
            "description": 'required|string|between:5, 40',
            "exercisesid": 'required|string|between:36,36',
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}