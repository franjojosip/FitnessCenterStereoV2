using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IStep : IBaseModel
    {
        #region Properties

        String Abbreviation { get; set; }
        String Description { get; set; }
        Guid ExercisesId { get; set; }
        String Name { get; set; }

        #endregion Properties
    }
}