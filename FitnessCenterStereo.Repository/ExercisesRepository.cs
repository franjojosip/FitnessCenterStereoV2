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
    public class ExercisesRepository : Repository<IExercises, Exercises, IExercisesFilter>, IExercisesRepository
    {
        #region Constructors

        public ExercisesRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        #endregion Constructors

        #region Methods

        protected override IQueryable<Exercises> ApplyFilter(IQueryable<Exercises> entities, IExercisesFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.BodyPartId.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.ComplexityLeveTypelId.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        protected override IQueryable<Exercises> ApplySort(IQueryable<Exercises> entities, IExercisesFilter filter)
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

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }
            return entities;
        }

        #endregion Methods
    }
}