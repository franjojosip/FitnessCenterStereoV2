using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface IScheduleService
    {
        #region Methods

        Task<ISchedule> CreateAsync(ISchedule schedule);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<ISchedule>> FindAsync(IScheduleFilter filter);

        Task<ISchedule> GetAsync(Guid id);

        Task<bool> UpdateAsync(ISchedule schedule);

        #endregion Methods
    }
}