using AutoMapper;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.WebApi.Models;

namespace FitnessCenterStereo.WebApi.Mappings
{
    public class MappingProfileViewDomain : Profile
    {
        #region Constructors

        public MappingProfileViewDomain()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap(typeof(WebApi.Infrastracture.Pagination.PaginatedList<>), typeof(Model.Common.Infrastracture.Pagination.PaginatedList<>)).ReverseMap();
            CreateMap<IBaseModel, BaseViewModel>().ReverseMap();
            CreateMap<IBodyPartType, BodyPartTypeViewModel>().ReverseMap();
            CreateMap<ICard, CardViewModel>().ReverseMap();
            CreateMap<IDietType, DietTypeViewModel>().ReverseMap();
            CreateMap<IEquipment, EquipmentViewModel>().ReverseMap();
            CreateMap<IExercises, ExercisesViewModel>().ReverseMap();
            CreateMap<IMembership, MembershipViewModel>().ReverseMap();
            CreateMap<IPlan, PlanViewModel>().ReverseMap();
            CreateMap<ISchedule, ScheduleViewModel>().ReverseMap();
            CreateMap<IStep, StepViewModel>().ReverseMap();
            CreateMap<ITrainer, TrainerViewModel>().ReverseMap();
            CreateMap<IComplexityLevelType, ComplexityLevelTypeViewModel>().ReverseMap();
        }

        #endregion Constructors
    }
}