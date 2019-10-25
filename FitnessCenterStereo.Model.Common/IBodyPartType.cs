using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IBodyPartType : IBaseModel
    {
        #region Properties

        String Abbreviation { get; set; }
        String Name { get; set; }

        #endregion Properties
    }
}