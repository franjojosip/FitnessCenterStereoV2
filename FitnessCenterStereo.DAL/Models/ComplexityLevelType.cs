using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class ComplexityLevelType : BaseModel
    {
        #region Constructors

        public ComplexityLevelType()
        {
            Exercises = new HashSet<Exercises>();
        }

        #endregion Constructors

        #region Properties

        public string Abbreviation { get; set; }

        public virtual ICollection<Exercises> Exercises { get; set; }

        public string Name { get; set; }

        #endregion Properties
    }
}