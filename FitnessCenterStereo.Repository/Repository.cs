using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Repository
{
    public class Repository<T, TEntity, TFilter> : IRepository<T, TFilter>
        where T : IBaseModel
        where TEntity : BaseModel
        where TFilter : IFilter
    {
        #region Constructors

        public Repository(ApplicationDbContext appDbContext, IMapper mapper)
        {
            AppDbContext = appDbContext;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected ApplicationDbContext AppDbContext { get; private set; }
        protected IMapper Mapper { get; private set; }

        #endregion Properties

        #region Methods

        public async Task<T> CreateAsync(T model)
        {
            try
            {
                model.Id = Guid.NewGuid();
                model.DateCreated = DateTime.UtcNow;
                model.DateUpdated = DateTime.UtcNow;
                AppDbContext.Set<TEntity>().Add(Mapper.Map<TEntity>(model));
                await AppDbContext.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var toDelete = AppDbContext.Set<TEntity>().Find(id);
                AppDbContext.Set<TEntity>().Remove(toDelete);
                return await AppDbContext.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<PaginatedList<T>> FindAsync(TFilter filter)
        {
            try
            {
                IQueryable<TEntity> entities = AppDbContext.Set<TEntity>().AsNoTracking();

                entities = ApplyFilter(entities, filter);
                entities = ApplySort(entities, filter);

                var count = await entities.CountAsync();

                var items = await entities.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToListAsync();

                return new PaginatedList<T>(Mapper.Map<IEnumerable<T>>(items), count, filter.Page, filter.RecordsPerPage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> GetAsync(Guid id)
        {
            try
            {
                return Mapper.Map<T>(await AppDbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateAsync(T model)
        {
            try
            {
                if (await GetAsync(model.Id) != null)
                {
                    model.DateUpdated = DateTime.UtcNow;
                    AppDbContext.Set<TEntity>().Update(Mapper.Map<TEntity>(model));
                    return await AppDbContext.SaveChangesAsync() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected virtual IQueryable<TEntity> ApplyFilter(IQueryable<TEntity> entities, TFilter filter)
        {
            return entities;
        }

        protected virtual IQueryable<TEntity> ApplySort(IQueryable<TEntity> entities, TFilter filter)
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

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }
            return entities;
        }

        #endregion Methods
    }
}