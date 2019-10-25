using AutoMapper;
using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;
using FitnessCenterStereo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ExercisesController : BaseApiController
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public ExercisesController(IExercisesService service, IMapper mapper, IFacadeFilter filter)
        {
            Mapper = mapper;
            Filter = filter;
            Service = service;
        }

        #endregion Constructors

        #region Properties

        protected IFacadeFilter Filter { get; private set; }
        protected IExercisesService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(Guid id)
        {
            return await Service.DeleteAsync(id);
        }

        [HttpGet]
        public async Task<PaginatedList<ExercisesViewModel>> FindAsync(string searchQuery = DefaultSearchQuery, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IExercisesFilter filter = Filter.CreateExercisesFilter();
            filter.SearchQuery = searchQuery;
            filter.Page = page;
            filter.RecordsPerPage = rpp;
            filter.SortBy = sortBy;
            filter.SortAscending = sortAsc;
            return Mapper.Map<PaginatedList<ExercisesViewModel>>(await Service.FindAsync(Mapper.Map<IExercisesFilter>(filter)));
        }

        // GET: api/<controller>
        [HttpGet("{id}")]
        public async Task<ExercisesViewModel> GetAsync(Guid id)
        {
            return Mapper.Map<ExercisesViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ExercisesViewModel> PostAsync([FromBody]ExercisesViewModel exercises)
        {
            return Mapper.Map<ExercisesViewModel>(await Service.CreateAsync(Mapper.Map<IExercises>(exercises)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public async Task<bool> PutAsync([FromBody]ExercisesViewModel value, [FromRoute]Guid id)
        {
            value.Id = id;
            return await Service.UpdateAsync(Mapper.Map<IExercises>(value));
        }

        #endregion Methods
    }
}