import BaseForm from '../../../common/components/BaseForm';

export default class ExercisesForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["name", "bodyparttypeid", "complexityleveltypeid"];
        const placeholder = {
            "name": "Enter name",
            "bodyparttypeid": "Enter body part type ID",
            "complexityleveltypeid": "Enter complexity level type ID"
        };
        const labels = {
            "name": "Name",
            "bodyparttypeid": "Body part type ID",
            "complexityleveltypeid": "Complexity level type ID"
        };
        const rules = {
            "name": 'required|string|between:3, 25',
            "bodyparttypeid": 'required|string|between:36, 36',
            "complexityleveltypeid": 'required|string|between:36, 36'
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}