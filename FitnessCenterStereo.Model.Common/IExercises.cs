using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExercises : IBaseModel
    {
        #region Properties

        Guid BodyPartId { get; set; }
        Guid ComplexityLevelTypeId { get; set; }
        String Name { get; set; }

        #endregion Properties
    }
}