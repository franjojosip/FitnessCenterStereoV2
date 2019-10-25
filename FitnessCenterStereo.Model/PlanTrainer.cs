using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class PlanTrainer : BaseModel, IPlanTrainer
    {
        #region Properties

        public Guid PlanId { get; set; }
        public Guid TrainerId { get; set; }

        #endregion Properties
    }
}