using AutoMapper;
using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    internal class PlanService : IPlanService
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public PlanService(IPlanRepository planRepository, IMapper mapper)
        {
            PlanRepository = planRepository;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected IPlanRepository PlanRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<IPlan> CreateAsync(IPlan plan)
        {
            return PlanRepository.CreateAsync(plan);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return PlanRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<IPlan>> FindAsync(IPlanFilter filter)
        {
            return PlanRepository.FindAsync(filter);
        }

        public Task<IPlan> GetAsync(Guid id)
        {
            return PlanRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(IPlan plan)
        {
            return PlanRepository.UpdateAsync(plan);
        }

        #endregion Methods
    }
}