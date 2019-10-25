using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class BaseModel : IBaseModel
    {
        #region Properties

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid Id { get; set; }

        #endregion Properties
    }
}