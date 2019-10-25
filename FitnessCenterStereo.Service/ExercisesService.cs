using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    internal class ExercisesService : IExercisesService
    {
        #region Constructors

        public ExercisesService(IExercisesRepository exercisesRepository)
        {
            ExercisesRepository = exercisesRepository;
        }

        #endregion Constructors

        #region Properties

        protected IExercisesRepository ExercisesRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<IExercises> CreateAsync(IExercises exercises)
        {
            return ExercisesRepository.CreateAsync(exercises);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return ExercisesRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<IExercises>> FindAsync(IExercisesFilter filter)
        {
            return ExercisesRepository.FindAsync(filter);
        }

        public Task<IExercises> GetAsync(Guid id)
        {
            return ExercisesRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(IExercises exercises)
        {
            return ExercisesRepository.UpdateAsync(exercises);
        }

        #endregion Methods
    }
}