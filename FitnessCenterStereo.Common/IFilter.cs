using System;

namespace FitnessCenterStereo.Common
{
    public interface IFilter
    {
        #region Properties

        int Page { get; set; }
        int RecordsPerPage { get; set; }
        String SearchQuery { get; set; }
        bool SortAscending { get; set; }
        String SortBy { get; set; }

        #endregion Properties
    }
}