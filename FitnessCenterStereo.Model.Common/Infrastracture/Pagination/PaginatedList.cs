using System.Collections.Generic;

namespace FitnessCenterStereo.Model.Common.Infrastracture.Pagination
{
    public class PaginatedList<T> where T : IBaseModel
    {
        #region Constructors

        public PaginatedList(IEnumerable<T> items, int count, int page, int pageSize)
        {
            Page = page;
            TotalItems = count;
            RecordsPerPage = pageSize;
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