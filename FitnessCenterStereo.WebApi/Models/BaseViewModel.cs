using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public abstract class BaseViewModel
    {
        #region Properties

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid Id { get; set; }

        #endregion Properties
    }
}