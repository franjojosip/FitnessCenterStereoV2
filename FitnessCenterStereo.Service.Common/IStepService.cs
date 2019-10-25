using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface IStepService
    {
        #region Methods

        Task<IStep> CreateAsync(IStep step);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<IStep>> FindAsync(IStepFilter filter);

        Task<IStep> GetAsync(Guid id);

        Task<bool> UpdateAsync(IStep step);

        #endregion Methods
    }
}