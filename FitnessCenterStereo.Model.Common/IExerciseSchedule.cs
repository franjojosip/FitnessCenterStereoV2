using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseSchedule : IBaseModel
    {
        #region Properties

        Guid ExerciseId { get; set; }
        Guid ScheduleId { get; set; }

        #endregion Properties
    }
}