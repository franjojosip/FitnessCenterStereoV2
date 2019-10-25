import React from 'react';
import { observer, inject } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import MembershipEditViewStore from '../stores/MembershipEditViewStore';
import SimpleInput from '../../../common/SimpleInput';
import { Button } from 'react-bootstrap';

@inject(stores => ({
    membershipEditViewStore: new MembershipEditViewStore(stores.rootStore)
}))
@observer
class MembershipEdit extends React.Component {
    render() {
        const { form, isLoading } = this.props.membershipEditViewStore;
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
                            <SimpleInput field={form.$('price')} />
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

export default MembershipEdit;