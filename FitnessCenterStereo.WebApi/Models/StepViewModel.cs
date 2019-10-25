using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public class StepViewModel : BaseViewModel
    {
        #region Properties

        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public Guid ExercisesId { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}