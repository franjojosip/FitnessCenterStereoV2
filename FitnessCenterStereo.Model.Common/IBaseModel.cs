using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IBaseModel
    {
        #region Properties

        DateTime DateCreated { get; set; }
        DateTime DateUpdated { get; set; }
        Guid Id { get; set; }

        #endregion Properties
    }
}