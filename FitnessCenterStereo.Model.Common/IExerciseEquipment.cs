using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseEquipment : IBaseModel
    {
        #region Properties

        Guid EquipmentId { get; set; }
        Guid ExerciseId { get; set; }

        #endregion Properties
    }
}