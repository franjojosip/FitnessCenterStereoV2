using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    internal class TrainerService : ITrainerService
    {
        #region Constructors

        public TrainerService(ITrainerRepository trainerRepository)
        {
            TrainerRepository = trainerRepository;
        }

        #endregion Constructors

        #region Properties

        protected ITrainerRepository TrainerRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<ITrainer> CreateAsync(ITrainer trainer)
        {
            return TrainerRepository.CreateAsync(trainer);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return TrainerRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<ITrainer>> FindAsync(ITrainerFilter filter)
        {
            return TrainerRepository.FindAsync(filter);
        }

        public Task<ITrainer> GetAsync(Guid id)
        {
            return TrainerRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(ITrainer trainer)
        {
            return TrainerRepository.UpdateAsync(trainer);
        }

        #endregion Methods
    }
}