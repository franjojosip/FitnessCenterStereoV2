using System;

namespace FitnessCenterStereo.Common
{
    public class Filter : IFilter
    {
        #region Fields

        private int page;
        private int rpp;

        #endregion Fields

        #region Properties

        public int Page
        {
            get
            {
                return page;
            }
            set
            {
                if (value < 1) page = 1;
                else page = value;
            }
        }

        public int RecordsPerPage
        {
            get
            {
                return rpp;
            }
            set
            {
                if (String.IsNullOrEmpty(value.ToString())) rpp = 10;
                else if (value < 10) rpp = 10;
                else if (value > 100) rpp = 100;
                else rpp = value;
            }
        }

        public string SearchQuery { get; set; }

        public bool SortAscending { get; set; }

        public string SortBy { get; set; }

        #endregion Properties
    }
}