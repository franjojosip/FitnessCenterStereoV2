using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    internal class StepService : IStepService
    {
        #region Constructors

        public StepService(IStepRepository stepRepository)
        {
            StepRepository = stepRepository;
        }

        #endregion Constructors

        #region Properties

        protected IStepRepository StepRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<IStep> CreateAsync(IStep step)
        {
            return StepRepository.CreateAsync(step);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return StepRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<IStep>> FindAsync(IStepFilter filter)
        {
            return StepRepository.FindAsync(filter);
        }

        public Task<IStep> GetAsync(Guid id)
        {
            return StepRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(IStep step)
        {
            return StepRepository.UpdateAsync(step);
        }

        #endregion Methods
    }
}