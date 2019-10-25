using FitnessCenterStereo.Model.Common;
using System.Collections.Generic;

namespace FitnessCenterStereo.Model
{
    public class DietType : BaseModel, IDietType
    {
        #region Properties

        public string Abbreviation { get; set; }
        public string Ingridients { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Plan> Plan { get; set; }

        #endregion Properties
    }
}