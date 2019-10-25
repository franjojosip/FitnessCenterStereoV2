using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface IExercisesService
    {
        #region Methods

        Task<IExercises> CreateAsync(IExercises exercises);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<IExercises>> FindAsync(IExercisesFilter filter);

        Task<IExercises> GetAsync(Guid id);

        Task<bool> UpdateAsync(IExercises exercises);

        #endregion Methods
    }
}