using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service.Common
{
    public interface ICardService
    {
        #region Methods

        Task<ICard> CreateAsync(ICard card);

        Task<bool> DeleteAsync(Guid id);

        Task<PaginatedList<ICard>> FindAsync(ICardFilter filter);

        Task<ICard> GetAsync(Guid id);

        Task<bool> UpdateAsync(ICard card);

        #endregion Methods
    }
}