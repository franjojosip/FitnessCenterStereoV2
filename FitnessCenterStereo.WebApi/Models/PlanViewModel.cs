using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public class PlanViewModel : BaseViewModel
    {
        #region Properties

        public Guid DietTypeId { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}