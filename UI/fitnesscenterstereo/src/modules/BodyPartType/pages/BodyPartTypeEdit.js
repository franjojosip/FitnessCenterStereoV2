import React from 'react';
import { observer, inject } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import BodyPartTypeEditViewStore from '../stores/BodyPartTypeEditViewStore';
import SimpleInput from '../../../common/SimpleInput';
import { Button } from 'react-bootstrap';

@inject(stores => ({
    bodyPartTypeEditViewStore: new BodyPartTypeEditViewStore(stores.rootStore)
}))
@observer
class BodyPartTypeEdit extends React.Component {
    render() {
        const { form, isLoading } = this.props.bodyPartTypeEditViewStore;
        return (
            <React.Fragment>
                <Layout>
                    {isLoading ?
                        <div>
                            Loading
                        </div>
                        :
                        <form>
                            <Button size='md' onClick={() => window.history.back()} variant="outline-success">Back</Button>
                            <SimpleInput field={form.$('name')} />
                            <SimpleInput field={form.$('abbreviation')} />
                            <button type="button" disabled={!form.isValid} onClick={form.onSubmit} className={'btn-primary'}>Submit</button>
                            <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                            <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>
                        </form>
                    }
                </Layout>
            </React.Fragment>
        );
    }
}

export default BodyPartTypeEdit;