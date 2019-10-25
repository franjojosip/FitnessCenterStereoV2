using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface IDietTypeService
    {
        #region Methods

        Task<IDietType> CreateAsync(IDietType dietType);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<IDietType>> FindAsync(IDietTypeFilter filter);

        Task<IDietType> GetAsync(Guid id);

        Task<bool> UpdateAsync(IDietType dietType);

        #endregion Methods
    }
}