import MobxReactForm from "mobx-react-form";
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import toaster from 'toasted-notes';


const plugins = {
  dvr: dvr(validatorjs),
};

const fields = [{
  name: 'FirstName',
  label: 'FirstName',
  placeholder: 'Enter first name',
  rules: 'required|string|between:3, 25',
}, {
  name: 'LastName',
  label: 'LastName',
  placeholder: 'Enter LastName',
  rules: 'required|string|between:5,100',
},
{
  name: 'DateHired',
  label: 'Datehired',
  placeholder: 'Enter hire date',
  rules: 'required|date',
}

];

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
