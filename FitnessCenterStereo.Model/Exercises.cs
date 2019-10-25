using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.Model
{
    public class Exercises : BaseModel, IExercises
    {
        #region Properties

        public virtual BodyPartType BodyPart { get; set; }
        public Guid BodyPartId { get; set; }
        public Guid ComplexityLevelTypeId { get; set; }
        public virtual ComplexityLevelType ComplexityLeveTypel { get; set; }
        public virtual ICollection<ExerciseEquipment> ExerciseEquipment { get; set; }
        public virtual ICollection<ExerciseSchedule> ExerciseSchedule { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}