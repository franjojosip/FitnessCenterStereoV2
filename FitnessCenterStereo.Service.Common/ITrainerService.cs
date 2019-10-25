using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface ITrainerService
    {
        #region Methods

        Task<ITrainer> CreateAsync(ITrainer trainer);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<ITrainer>> FindAsync(ITrainerFilter filter);

        Task<ITrainer> GetAsync(Guid id);

        Task<bool> UpdateAsync(ITrainer trainer);

        #endregion Methods
    }
}