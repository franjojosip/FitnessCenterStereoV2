using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface IEquipmentService
    {
        #region Methods

        Task<IEquipment> CreateAsync(IEquipment equipment);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<IEquipment>> FindAsync(IEquipmentFilter filter);

        Task<IEquipment> GetAsync(Guid id);

        Task<bool> UpdateAsync(IEquipment equipment);

        #endregion Methods
    }
}