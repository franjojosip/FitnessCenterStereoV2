using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Trainer : BaseModel
    {
        #region Constructors

        public Trainer()
        {
            PlanTrainers = new HashSet<PlanTrainer>();
        }

        #endregion Constructors

        #region Properties

        public string FirstName { get; set; }
        public DateTime? HiredAt { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<PlanTrainer> PlanTrainers { get; set; }

        #endregion Properties
    }
}