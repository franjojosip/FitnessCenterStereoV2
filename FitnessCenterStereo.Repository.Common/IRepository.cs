using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IRepository<T, TFilter>
        where T : IBaseModel
        where TFilter : IFilter

    {
        #region Methods

        Task<T> CreateAsync(T model);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<T>> FindAsync(TFilter filter);

        Task<T> GetAsync(Guid id);

        Task<bool> UpdateAsync(T model);

        #endregion Methods
    }
}