using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface IPlanService
    {
        #region Methods

        Task<IPlan> CreateAsync(IPlan plan);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<IPlan>> FindAsync(IPlanFilter filter);

        Task<IPlan> GetAsync(Guid id);

        Task<bool> UpdateAsync(IPlan plan);

        #endregion Methods
    }
}