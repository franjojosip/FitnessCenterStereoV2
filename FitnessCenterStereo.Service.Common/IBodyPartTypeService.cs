using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface IBodyPartTypeService
    {
        #region Methods

        Task<IBodyPartType> CreateAsync(IBodyPartType bodyPartType);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<IBodyPartType>> FindAsync(IBodyPartTypeFilter filter);

        Task<IBodyPartType> GetAsync(Guid id);

        Task<bool> UpdateAsync(IBodyPartType bodyPartType);

        #endregion Methods
    }
}