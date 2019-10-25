using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IDietType : IBaseModel
    {
        #region Properties

        String Abbreviation { get; set; }
        String Ingridients { get; set; }
        String Name { get; set; }

        #endregion Properties
    }
}