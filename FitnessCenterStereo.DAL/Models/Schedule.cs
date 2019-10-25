using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Schedule : BaseModel
    {
        #region Constructors

        public Schedule()
        {
            ExerciseSchedule = new HashSet<ExerciseSchedule>();
        }

        #endregion Constructors

        #region Properties

        public virtual ICollection<ExerciseSchedule> ExerciseSchedule { get; set; }
        public int? Frequency { get; set; }

        public virtual Plan Plan { get; set; }
        public Guid? PlanId { get; set; }

        #endregion Properties
    }
}