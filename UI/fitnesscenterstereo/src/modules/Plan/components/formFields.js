import MobxReactForm from "mobx-react-form";
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import toaster from 'toasted-notes';
const plugins = {
  dvr: dvr(validatorjs),
};
const fields = [{
  name: 'name',
  label: 'Name',
  placeholder: 'Enter plan name',
  rules: 'required|string|between:3, 25',
}, {
  name: 'dietTypeId',
  label: 'Diet Type ID',
  placeholder: 'Enter diet type',
  rules: 'required|string|between:32, 32',
}];
const hooks = {
  onSuccess(form) {
    console.log('Form Values!', form.values());
    toaster.notify('Form is valid!', {
      duration: 2000
    })
  },
  onError(form) {
    console.log('All form errors', form.errors());
    toaster.notify('Form is invalid!', {
      duration: 2000
    })
  }
}
export default new MobxReactForm({ fields }, { plugins, hooks });
