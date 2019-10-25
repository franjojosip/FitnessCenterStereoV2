import React from 'react';
import Layout from '../../../common/layouts/Layout';
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import ExercisesViewStore from '../stores/ExercisesViewStore'
import MaterialTable from 'material-table';
import EditIcon from '@material-ui/icons/Edit';
import DeleteIcon from '@material-ui/icons/Delete';
import Modal from 'react-bootstrap/Modal'


@inject(stores => ({
    exercisesViewStore: new ExercisesViewStore(stores.rootStore)
}))
@observer
class Exercises extends React.Component {
    render() {
        const { searchQuery, isLoading, columns, isDeleting, page, recordsPerPage, displayItems, itemToDeleteName, onUpdate, onCreate, onFind, onDelete, onSearchQueryChange, onRecordsPerPageChange, onSortChange, onPageChange, onConfirmDelete, onCancelDelete } = this.props.exercisesViewStore;
        return (
            <React.Fragment>
                <Layout>
                    <div className="row justify-content-between">
                        <div className="col-6">
                            <Button onClick={() => onCreate()}>Create</Button>
                        </div>
                        <div className="col-3">
                            <FormControl type="text" value={searchQuery} onChange={e => onSearchQueryChange(e.target.value)} placeholder="Search" className="mr-sm-2" />
                        </div>
                        <div className="col-3">
                            <Button onClick={() => onFind()}>Search</Button>
                        </div>
                    </div>
                    <div>
                        {isLoading ? "Loading items..." : ""}
                    </div>
                    <div>
                        <MaterialTable
                            onChangeRowsPerPage={(pageSize) => onRecordsPerPageChange(pageSize)}
                            onChangePage={(page) => onPageChange(page)}
                            onOrderChange={(orderBy, orderDirection) => onSortChange(orderBy, orderDirection)}
                            columns={columns}
                            data={
                                isLoading ? [] : displayItems
                            }
                            actions={[
                                rowData => ({
                                    icon: () => <EditIcon />,
                                    tooltip: 'Edit entry',
                                    onClick: (event, rowData) => onUpdate(rowData.id)
                                }),
                                rowData => ({
                                    icon: () => <DeleteIcon />,
                                    tooltip: 'Delete entry',
                                    onClick: (event, rowData) => onDelete(rowData.id, rowData.name)
                                })
                            ]}
                            options={{
                                search: false,
                                page: page,
                                pageSizeOptions: [10, 25, 50, 100],
                                pageSize: recordsPerPage,
                                actionsColumnIndex: -1,
                                isLoading: isLoading
                            }}
                            title="Exercises"
                        />
                    </div>
                </Layout>
                <Modal show={isDeleting} onHide={(onCancelDelete)}>
                    <Modal.Header closeButton>
                        <Modal.Title>Delete entry</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>Are you sure you want to delete entry: {itemToDeleteName}?</Modal.Body>
                    <Modal.Footer>
                        <Button variant="secondary" onClick={onCancelDelete}>
                            Cancel
                        </Button>
                        <Button variant="primary" onClick={onConfirmDelete}>
                            Delete
                        </Button>
                    </Modal.Footer>
                </Modal>
            </React.Fragment>
        )
    }
}

export default Exercises;