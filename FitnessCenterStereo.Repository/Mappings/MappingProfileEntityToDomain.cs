using AutoMapper;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;

namespace FitnessCenterStereo.Repository.Mappings
{
    public class MappingProfileEntityDomain : Profile
    {
        #region Constructors

        public MappingProfileEntityDomain()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<BodyPartType, IBodyPartType>().ReverseMap();
            CreateMap<ComplexityLevelType, IComplexityLevelType>().ReverseMap();
            CreateMap<Card, ICard>().ReverseMap();
            CreateMap<DietType, IDietType>().ReverseMap();
            CreateMap<Equipment, IEquipment>().ReverseMap();
            CreateMap<ExerciseEquipment, IExerciseEquipment>().ReverseMap();
            CreateMap<ExerciseSchedule, IExerciseSchedule>().ReverseMap();
            CreateMap<Exercises, IExercises>().ReverseMap();
            CreateMap<Membership, IMembership>().ReverseMap();
            CreateMap<Plan, IPlan>().ReverseMap();
            CreateMap<PlanTrainer, IPlanTrainer>().ReverseMap();
            CreateMap<Schedule, ISchedule>().ReverseMap();
            CreateMap<Step, IStep>().ReverseMap();
            CreateMap<Trainer, ITrainer>().ReverseMap();
        }

        #endregion Constructors
    }
}