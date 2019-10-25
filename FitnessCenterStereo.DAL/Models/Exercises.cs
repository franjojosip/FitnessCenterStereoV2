using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Exercises : BaseModel
    {
        #region Constructors

        public Exercises()
        {
            ExerciseEquipment = new HashSet<ExerciseEquipment>();
            ExerciseSchedule = new HashSet<ExerciseSchedule>();
            Step = new HashSet<Step>();
        }

        #endregion Constructors

        #region Properties

        public virtual BodyPartType BodyPart { get; set; }
        public Guid? BodyPartId { get; set; }
        public virtual ComplexityLevelType ComplexityLeveTypel { get; set; }
        public Guid? ComplexityLeveTypelId { get; set; }

        public virtual ICollection<ExerciseEquipment> ExerciseEquipment { get; set; }
        public virtual ICollection<ExerciseSchedule> ExerciseSchedule { get; set; }

        public string Name { get; set; }
        public virtual ICollection<Step> Step { get; set; }

        #endregion Properties
    }
}