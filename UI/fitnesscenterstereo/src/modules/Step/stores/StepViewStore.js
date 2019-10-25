import { observable, action } from 'mobx';
import toaster from 'toasted-notes';

class StepViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.stepModuleStore.stepDataStore;
        this.routerStore = rootStore.routerStore;
        this.onFind();
    }

    @observable isLoading = true;
    @observable isDeleting = false
    @observable itemToDeleteName;
    @observable itemToDeleteId;
    @observable filter;
    @observable page = 1;
    @observable recordsPerPage = 10;
    @observable sortBy = "name";
    @observable sortAsc = true;
    @observable searchQuery = "";
    resultItems;
    displayItems;
    columns = [
        { title: "Name", field: "name" },
        { title: "Abbreviation", field: "abbreviation" },
        { title: "Description", field: "description" },
        { title: "Exercises ID", field: "exercisesid" }
    ];
    @action.bound onCreate() {
        this.routerStore.goTo("stepcreate");
    };

    @action.bound onUpdate(id) {
        this.routerStore.goTo("stepedit", { id: id });
    }

    @action.bound onDelete(id, name) {
        this.itemToDeleteName = name;
        this.itemToDeleteId = id;
        this.isDeleting = true;
    }

    @action.bound async onConfirmDelete() {
        this.deleteResult = await this.dataStore.delete(this.itemToDeleteId);
        if (this.deleteResult) {
            this.isDeleting = false;
            toaster.notify('Deletion successful!', {
                duration: 2000
            })
            this.onFind();
        } else {
            toaster.notify('Deletion failed!', {
                duration: 2000
            })
        }
    }

    @action.bound onCancelDelete() {
        this.isDeleting = false;
        this.itemToDeleteName = null;
        this.itemToDeleteId = null;
    }

    @action.bound async onFind() {
        this.isLoading = true;
        this.filter = "sortBy=" + this.sortBy + "&sortAsc=" + this.sortAsc + "&page=" + this.page +  "&rpp=" + this.recordsPerPage + "&searchQuery=" + this.searchQuery;
        this.resultItems = await this.dataStore.find(this.filter);
        this.resultsToArray();
        this.isLoading = false;
    };

    resultsToArray = () => {
        this.displayItems = [];
        for (let i = 0; i < this.resultItems.items.length; i++) {
            this.displayItems.push({
                id: this.resultItems.items[i].id,
                name: this.resultItems.items[i].name,
                abbreviation: this.resultItems.items[i].abbreviation,
                ingredients: this.resultItems.items[i].ingridients
            });
        }
    }

    @action.bound onPageChange(page) {
        this.page = page;
        this.onFind();
    }

    @action.bound onRecordsPerPageChange(recordsPerPage) {
        this.recordsPerPage = recordsPerPage;
        this.onFind();
    }

    @action.bound onSearchQueryChange(searchQuery) {
        this.searchQuery = searchQuery;
    }

    @action.bound onSortChange(sortBy, sortAsc) {
        this.sortAsc = sortAsc === "asc";
        this.sortBy = this.columns[sortBy].field;
        this.onFind();
    }
}

export default StepViewStore;