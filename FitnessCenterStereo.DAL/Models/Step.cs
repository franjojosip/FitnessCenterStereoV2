using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Step : BaseModel
    {
        #region Properties

        public string Abbreaviaton { get; set; }

        public string Description { get; set; }
        public virtual Exercises Exercises { get; set; }
        public Guid? ExercisesId { get; set; }

        public string Name { get; set; }

        #endregion Properties
    }
}