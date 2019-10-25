import ExercisesDataStore from './ExercisesDataStore';

export default class ExercisesModuleStore {
    constructor(rootStore) {
        this.rootStore = rootStore;
        this.exercisesDataStore = new ExercisesDataStore();
    }
}