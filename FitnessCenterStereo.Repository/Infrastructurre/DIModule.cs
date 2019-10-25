using Autofac;
using AutoMapper;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Repository.Infrastructurre
{
    public class DIModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf();
            builder.RegisterType<IMapper>().AsSelf();
            builder.RegisterType<BodyPartTypeRepository>().As<IBodyPartTypeRepository>();
            builder.RegisterType<CardRepository>().As<ICardRepository>();
            builder.RegisterType<ComplexityLevelTypeRepository>().As<IComplexityLevelTypeRepository>();
            builder.RegisterType<DietTypeRepository>().As<IDietTypeRepository>();
            builder.RegisterType<EquipmentRepository>().As<IEquipmentRepository>();
            builder.RegisterType<ExercisesRepository>().As<IExercisesRepository>();
            builder.RegisterType<MembershipRepository>().As<IMembershipRepository>();
            builder.RegisterType<PlanRepository>().As<IPlanRepository>();
            builder.RegisterType<ScheduleRepository>().As<IScheduleRepository>();
            builder.RegisterType<StepRepositoy>().As<IStepRepository>();
            builder.RegisterType<TrainerRepository>().As<ITrainerRepository>();
        }

        #endregion Methods
    }
}