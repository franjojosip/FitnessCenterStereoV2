import BaseForm from '../../../common/components/BaseForm';

export default class TrainerForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["firstname", "lastName", "hiredAt"];
        const placeholder = {
            "firstname": "Enter first name",
            "lastName": "Enter last name",
            "hiredAt": "Enter date hired"
        };
        const labels = {
            "firstname": "Frequency",
            "lastName": "Last Name",
            "hiredAt": "Date hired"
        };
        const rules = {
            "firstname": 'required|string|between:3, 40',
            "lastName": 'required|string|between:3, 40',
            "hiredAt": 'required|date',
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}