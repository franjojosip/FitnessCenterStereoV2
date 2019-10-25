using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface ISchedule : IBaseModel
    {
        #region Properties

        int Frequency { get; set; }

        Guid PlanId { get; set; }

        #endregion Properties
    }
}