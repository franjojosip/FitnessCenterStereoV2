import MobxReactForm from "mobx-react-form";
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import toaster from 'toasted-notes';
const plugins = {
  dvr: dvr(validatorjs),
};
const fields = [{
  name: 'abrv',
  label: 'Abbreviation',
  placeholder: 'Enter abbreviation',
  rules: 'required|string|between:3, 25',
}, {
  name: 'name',
  label: 'Name',
  placeholder: 'Enter step name',
  rules: 'required|string|between:3, 25',
}, {
  name: 'desc',
  label: 'Description',
  placeholder: 'Enter step descrioption',
  rules: 'required|string|between:3, 200',
}, {
  name: 'exercisesid',
  label: 'Exercises ID',
  placeholder: 'Enter exercise',
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
