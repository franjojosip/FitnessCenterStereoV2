using System;

namespace FitnessCenterStereo.DAL.Models
{
    public class BaseModel
    {
        #region Properties

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid Id { get; set; }

        #endregion Properties
    }
}