using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.Model
{
    public class Plan : BaseModel, IPlan
    {
        #region Properties

        public virtual DietType DietType { get; set; }
        public Guid DietTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PlanTrainer> PlanTrainers { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }

        #endregion Properties
    }
}