using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class ExerciseEquipment : BaseModel
    {
        #region Properties

        public virtual Equipment Equipment { get; set; }
        public Guid? EquipmentId { get; set; }
        public virtual Exercises Exercises { get; set; }
        public Guid? ExercisesId { get; set; }

        #endregion Properties
    }
}