using FitnessCenterStereo.Model.Common;
using System.Collections.Generic;

namespace FitnessCenterStereo.Model
{
    public class BodyPartType : BaseModel, IBodyPartType
    {
        #region Properties

        public string Abbreviation { get; set; }
        public virtual ICollection<Exercises> Exercises { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}