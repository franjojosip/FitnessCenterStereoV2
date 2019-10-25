using FitnessCenterStereo.Model.Common;
using System.Collections.Generic;

namespace FitnessCenterStereo.Model
{
    public class ComplexityLevelType : BaseModel, IComplexityLevelType
    {
        #region Properties

        public string Abbreviation { get; set; }
        public virtual ICollection<Exercises> Exercises { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}