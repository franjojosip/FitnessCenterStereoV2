using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class DietType : BaseModel
    {
        #region Constructors

        public DietType()
        {
            Plan = new HashSet<Plan>();
        }

        #endregion Constructors

        #region Properties

        public string Abbreviation { get; set; }

        public string Ingridients { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Plan> Plan { get; set; }

        #endregion Properties
    }
}