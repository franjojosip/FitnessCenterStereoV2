
import BaseForm from '../../../common/components/BaseForm';


export default class PlanForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["dietTypeId", "name"];
        const placeholder = {
            "dietTypeId": "Enter dietTypeId",
            "name": "Enter Name"
        };
        const labels = {
            "dietTypeId":"DietTypeId",
            "name": "Name",
        };
        const rules = {
            "name": 'required|string|between:3, 25',
            "dietTypeId": 'required|string|between:36, 36'
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}
