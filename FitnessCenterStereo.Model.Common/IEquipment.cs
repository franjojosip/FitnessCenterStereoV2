using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IEquipment : IBaseModel
    {
        #region Properties

        String Name { get; set; }

        #endregion Properties
    }
}