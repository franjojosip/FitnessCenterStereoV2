using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Equipment : BaseModel
    {
        #region Constructors

        public Equipment()
        {
            ExerciseEquipment = new HashSet<ExerciseEquipment>();
        }

        #endregion Constructors

        #region Properties

        public virtual ICollection<ExerciseEquipment> ExerciseEquipment { get; set; }

        public string Name { get; set; }

        #endregion Properties
    }
}