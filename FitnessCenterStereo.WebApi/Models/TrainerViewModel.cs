using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public class TrainerViewModel : BaseViewModel
    {
        #region Properties

        public string Firstname { get; set; }
        public DateTime HiredAt { get; set; }
        public string LastName { get; set; }

        #endregion Properties
    }
}