using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    internal class ScheduleService : IScheduleService
    {
        #region Constructors

        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            ScheduleRepository = scheduleRepository;
        }

        #endregion Constructors

        #region Properties

        protected IScheduleRepository ScheduleRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<ISchedule> CreateAsync(ISchedule schedule)
        {
            return ScheduleRepository.CreateAsync(schedule);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return ScheduleRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<ISchedule>> FindAsync(IScheduleFilter filter)
        {
            return ScheduleRepository.FindAsync(filter);
        }

        public Task<ISchedule> GetAsync(Guid id)
        {
            return ScheduleRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(ISchedule schedule)
        {
            return ScheduleRepository.UpdateAsync(schedule);
        }

        #endregion Methods
    }
}