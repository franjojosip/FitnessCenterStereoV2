using AutoMapper;
using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Linq;

namespace FitnessCenterStereo.Repository
{
    public class ComplexityLevelTypeRepository : Repository<IComplexityLevelType, ComplexityLevelType, IComplexityLevelTypeFilter>, IComplexityLevelTypeRepository
    {
        #region Constructors

        public ComplexityLevelTypeRepository(ApplicationDbContext appDbContext, IMapper mapper) : base(appDbContext, mapper)
        {
        }

        #endregion Constructors

        #region Methods

        protected override IQueryable<ComplexityLevelType> ApplyFilter(IQueryable<ComplexityLevelType> entities, IComplexityLevelTypeFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Abbreviation.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        protected override IQueryable<ComplexityLevelType> ApplySort(IQueryable<ComplexityLevelType> entities, IComplexityLevelTypeFilter filter)
        {
            switch (filter.SortBy.ToLowerInvariant())
            {
                case "datecreated":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.DateCreated);
                    else
                        entities = entities.OrderBy(c => c.DateCreated);
                    break;

                case "dateupdated":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.DateUpdated);
                    else
                        entities = entities.OrderBy(c => c.DateUpdated);
                    break;

                case "name":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Name);
                    else
                        entities = entities.OrderBy(c => c.Name);
                    break;

                case "abbreviation":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Abbreviation);
                    else
                        entities = entities.OrderBy(c => c.Abbreviation);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }
            return entities;
        }

        #endregion Methods
    }
}