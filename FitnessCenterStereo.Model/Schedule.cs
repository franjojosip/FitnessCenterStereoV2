using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.Model
{
    public class Schedule : BaseModel, ISchedule
    {
        #region Properties

        public virtual ICollection<ExerciseSchedule> ExerciseSchedule { get; set; }
        public int Frequency { get; set; }

        public Guid PlanId { get; set; }

        #endregion Properties
    }
}