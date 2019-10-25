import React from 'react';
import { observer, inject } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import TrainerEditViewStore from '../stores/TrainerEditViewStore';
import SimpleInput from '../../../common/SimpleInput';
import { Button } from 'react-bootstrap';


@inject(stores => ({
    trainerEditViewStore: new TrainerEditViewStore(stores.rootStore)
}))
@observer
class TrainerEdit extends React.Component {
    render() {
        const { form, isLoading } = this.props.trainerEditViewStore;
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
                            <SimpleInput field={form.$('firstname')} />
                            <SimpleInput field={form.$('lastName')} />
                            <SimpleInput field={form.$('hiredAt')} />
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

export default TrainerEdit;


