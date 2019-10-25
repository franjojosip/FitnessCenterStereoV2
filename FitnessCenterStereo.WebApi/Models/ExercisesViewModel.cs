using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ExercisesViewModel : BaseViewModel
    {
        #region Properties

        public Guid BodyPartId { get; set; }
        public Guid ComplexityLevelTypeId { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}