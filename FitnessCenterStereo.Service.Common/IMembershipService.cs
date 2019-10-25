using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface IMembershipService
    {
        #region Methods

        Task<IMembership> CreateAsync(IMembership membership);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<IMembership>> FindAsync(IMembershipFilter filter);

        Task<IMembership> GetAsync(Guid id);

        Task<bool> UpdateAsync(IMembership membership);

        #endregion Methods
    }
}