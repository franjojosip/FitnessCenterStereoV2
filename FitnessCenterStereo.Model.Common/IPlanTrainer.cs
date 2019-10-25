using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IPlanTrainer : IBaseModel
    {
        #region Properties

        Guid PlanId { get; set; }
        Guid TrainerId { get; set; }

        #endregion Properties
    }
}