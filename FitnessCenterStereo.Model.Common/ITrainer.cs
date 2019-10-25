using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface ITrainer : IBaseModel
    {
        #region Properties

        String Firstname { get; set; }
        DateTime HiredAt { get; set; }
        String LastName { get; set; }

        #endregion Properties
    }
}