using FitnessCenterStereo.Model.Common;
using System.Collections.Generic;

namespace FitnessCenterStereo.Model
{
    public class Equipment : BaseModel, IEquipment
    {
        #region Properties

        public virtual ICollection<ExerciseEquipment> ExerciseEquipment { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}