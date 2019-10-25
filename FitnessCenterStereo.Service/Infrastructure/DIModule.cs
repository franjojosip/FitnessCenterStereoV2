using Autofac;
using FitnessCenterStereo.Service.Common;

namespace FitnessCenterStereo.Service.Infrastructure
{
    public class DIModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BodyPartTypeService>().As<IBodyPartTypeService>();
            builder.RegisterType<CardService>().As<ICardService>();
            builder.RegisterType<ComplexityLevelTypeService>().As<IComplexityLevelTypeService>();
            builder.RegisterType<DietTypeService>().As<IDietTypeService>();
            builder.RegisterType<EquipmentService>().As<IEquipmentService>();
            builder.RegisterType<ExercisesService>().As<IExercisesService>();
            builder.RegisterType<MembershipService>().As<IMembershipService>();
            builder.RegisterType<PlanService>().As<IPlanService>();
            builder.RegisterType<ScheduleService>().As<IScheduleService>();
            builder.RegisterType<StepService>().As<IStepService>();
            builder.RegisterType<TrainerService>().As<ITrainerService>();
        }

        #endregion Methods
    }
}