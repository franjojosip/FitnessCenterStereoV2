using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ScheduleViewModel : BaseViewModel
    {
        #region Properties

        public int Frequency { get; set; }
        public Guid PlanId { get; set; }

        #endregion Properties
    }
}