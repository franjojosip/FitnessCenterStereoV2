namespace FitnessCenterStereo.Common.Filters
{
    public interface IFacadeFilter
    {
        #region Methods

        IBodyPartTypeFilter CreateBodyPartTypeFilter();

        ICardFilter CreateCardFilter();

        IComplexityLevelTypeFilter CreateComplexityLevelTypeFilter();

        IDietTypeFilter CreateDietTypeFilter();

        IEquipmentFilter CreateEquipmentFilter();

        IExercisesFilter CreateExercisesFilter();

        IMembershipFilter CreateMembershipFilter();

        IPlanFilter CreatePlanFilter();

        IScheduleFilter CreateScheduleFilter();

        IStepFilter CreateStepFilter();

        ITrainerFilter CreateTrainerFilter();

        #endregion Methods
    }
}