using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class PlanTrainer : BaseModel
    {
        #region Properties

        public virtual Plan Plan { get; set; }
        public Guid? PlanId { get; set; }
        public virtual ICollection<PlanTrainer> PlanTrainers { get; set; }
        public virtual Trainer Trainer { get; set; }
        public Guid TrainerId { get; set; }

        #endregion Properties
    }
}