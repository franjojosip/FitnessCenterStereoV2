using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface IComplexityLevelTypeService
    {
        #region Methods

        Task<IComplexityLevelType> CreateAsync(IComplexityLevelType complexityLevel);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<IComplexityLevelType>> FindAsync(IComplexityLevelTypeFilter filter);

        Task<IComplexityLevelType> GetAsync(Guid id);

        Task<bool> UpdateAsync(IComplexityLevelType complexityLevel);

        #endregion Methods
    }
}