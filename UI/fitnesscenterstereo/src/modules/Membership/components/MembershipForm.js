
import BaseForm from '../../../common/components/BaseForm';


export default class MembershipForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["price"];
        const placeholder = {
            "dietyTypeId": "Enter dietyTypeId",
            "name":"Enter name"
          
        };
        const labels = {
            "dietyTypeId": "DietyTypeId",
            "name":"Name"
            
        };
        const rules = {
            "dietyTypeId": 'required|string|between:32, 32',
            "name":'required|string|between:3, 25'
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}
