using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.Model
{
    public class Trainer : BaseModel, ITrainer
    {
        #region Constructors

        public Trainer()
        {
            PlanTrainers = new HashSet<PlanTrainer>();
        }

        #endregion Constructors

        #region Properties

        public string Firstname { get; set; }
        public DateTime HiredAt { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<PlanTrainer> PlanTrainers { get; set; }

        #endregion Properties
    }
}