using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    internal class Step : BaseModel, IStep
    {
        #region Properties

        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public Guid ExercisesId { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}