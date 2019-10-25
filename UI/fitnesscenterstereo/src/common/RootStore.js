import { RouterState, RouterStore } from 'mobx-state-router';
import { routes } from './Routes';
import BodyPartTypeModuleStore from '../modules/BodyPartType/stores/BodyPartTypeModuleStore';
import ComplexityLevelTypeModuleStore from '../modules/ComplexityLevelType/stores/ComplexityLevelTypeModuleStore';
import DietTypeModuleStore from '../modules/DietType/stores/DietTypeModuleStore';
import EquipmentModuleStore from '../modules/Equipment/stores/EquipmentModuleStore';
import MembershipModuleStore from '../modules/Membership/stores/MembershipModuleStore';
import ScheduleModuleStore from '../modules/Schedule/stores/ScheduleModuleStore';
import TrainerModuleStore from '../modules/Trainer/stores/TrainerModuleStore';
import PlanModuleStore from '../modules/Plan/stores/PlanModuleStore';
import StepModuleStore from '../modules/Step/stores/StepModuleStore'

const notFound = new RouterState('notFound');

export class RootStore {
    constructor() {
        this.bodyPartTypeModuleStore = new BodyPartTypeModuleStore(this);
        this.complexityLevelTypeModuleStore = new ComplexityLevelTypeModuleStore(this);
        this.dietTypeModuleStore = new DietTypeModuleStore(this);
        this.equipmentModuleStore = new EquipmentModuleStore(this);
        this.exercisesModuleStore = new ExercisesModuleStore(this);
        this.membershipModuleStore = new MembershipModuleStore(this);
        this.scheduleModuleStore = new ScheduleModuleStore(this);
        this.trainerModuleStore = new TrainerModuleStore(this);
        this.membershipModuleStore=new MembershipModuleStore(this);
        this.planModuleStore=new PlanModuleStore(this);
        this.stepModuleStore = new StepModuleStore(this);
    }
    routerStore = new RouterStore(this, routes, notFound);

}
