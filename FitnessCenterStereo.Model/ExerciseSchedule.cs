using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class ExerciseSchedule : BaseModel, IExerciseSchedule
    {
        #region Properties

        public Guid ExerciseId { get; set; }
        public virtual Exercises Exercises { get; set; }
        public virtual Schedule Schedule { get; set; }
        public Guid ScheduleId { get; set; }

        #endregion Properties
    }
}