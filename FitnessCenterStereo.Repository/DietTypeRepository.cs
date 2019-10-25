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
    public class DietTypeRepository : Repository<IDietType, DietType, IDietTypeFilter>, IDietTypeRepository
    {
        #region Constructors

        public DietTypeRepository(ApplicationDbContext appDbContext, IMapper mapper) : base(appDbContext, mapper)
        {
        }

        #endregion Constructors

        #region Methods

        protected override IQueryable<DietType> ApplyFilter(IQueryable<DietType> entities, IDietTypeFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Abbreviation.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Ingridients.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        protected override IQueryable<DietType> ApplySort(IQueryable<DietType> entities, IDietTypeFilter filter)
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

                case "abbreviation":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Abbreviation);
                    else
                        entities = entities.OrderBy(c => c.Abbreviation);
                    break;

                case "ingridients":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Ingridients);
                    else
                        entities = entities.OrderBy(c => c.Ingridients);
                    break;

                case "name":
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