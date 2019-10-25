using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class ExerciseEquipment : BaseModel, IExerciseEquipment
    {
        #region Properties

        public virtual Equipment Equipment { get; set; }
        public Guid EquipmentId { get; set; }
        public Guid ExerciseId { get; set; }
        public virtual Exercises Exercises { get; set; }

        #endregion Properties
    }
}