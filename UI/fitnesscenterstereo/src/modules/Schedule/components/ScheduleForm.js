import BaseForm from '../../../common/components/BaseForm';

export default class ScheduleForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["frequency", "planId"];
        const placeholder = {
            "frequency": "Enter frequency",
            "planId": "Enter plan ID"
        };
        const labels = {
            "frequency": "Frequency",
            "planId": "Plan ID",
        };
        const rules = {
            "frequency": 'required|string|between:1, 2',
            "planId": 'required|string|between:36, 36',
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}