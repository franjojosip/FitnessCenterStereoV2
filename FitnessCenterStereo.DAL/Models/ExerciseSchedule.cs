using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class ExerciseSchedule : BaseModel
    {
        #region Properties

        public virtual Exercises Exercises { get; set; }
        public Guid? ExercisesId { get; set; }

        public virtual Schedule Schedule { get; set; }
        public Guid? ScheduleId { get; set; }

        #endregion Properties
    }
}