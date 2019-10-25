using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IPlan : IBaseModel
    {
        #region Properties

        Guid DietTypeId { get; set; }
        String Name { get; set; }

        #endregion Properties
    }
}