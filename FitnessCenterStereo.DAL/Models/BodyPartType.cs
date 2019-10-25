using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class BodyPartType : BaseModel
    {
        #region Constructors

        public BodyPartType()
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