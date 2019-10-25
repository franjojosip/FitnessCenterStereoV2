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
    public class MembershipRepository : Repository<IMembership, Membership, IMembershipFilter>, IMembershipRepository
    {
        #region Constructors

        public MembershipRepository(ApplicationDbContext appDbContext, IMapper mapper) : base(appDbContext, mapper)
        {
        }

        #endregion Constructors

        #region Methods

        protected override IQueryable<Membership> ApplyFilter(IQueryable<Membership> entities, IMembershipFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Price.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        protected override IQueryable<Membership> ApplySort(IQueryable<Membership> entities, IMembershipFilter filter)
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

                case "price":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Price);
                    else
                        entities = entities.OrderBy(c => c.Price);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }
            return entities;
        }

        #endregion Methods
    }
}