using FitnessCenterStereo.WebApi.Models;
using System.Collections.Generic;

namespace FitnessCenterStereo.WebApi.Infrastracture.Pagination
{
    public class PaginatedList<T> where T : BaseViewModel
    {
        #region Constructors

        public PaginatedList(IEnumerable<T> items, int page, int totalItems, int recordsPerPage)
        {
            Page = page;
            TotalItems = totalItems;
            RecordsPerPage = recordsPerPage;
            Items = items;
        }

        #endregion Constructors

        #region Properties

        public IEnumerable<T> Items { get; private set; }
        public int Page { get; private set; }
        public int RecordsPerPage { get; private set; }
        public int TotalItems { get; private set; }

        #endregion Properties
    }
}