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
    public class StepController : BaseApiController
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public StepController(IStepService service, IMapper mapper, IFacadeFilter filter)
        {
            Mapper = mapper;
            Service = service;
            Filter = filter;
        }

        #endregion Constructors

        #region Properties

        protected IFacadeFilter Filter { get; private set; }
        protected IStepService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(Guid id)
        {
            return await Service.DeleteAsync(id);
        }

        [HttpGet]
        public async Task<PaginatedList<StepViewModel>> FindAsync(string searchQuery = DefaultSearchQuery, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IStepFilter filter = Filter.CreateStepFilter();
            filter.SearchQuery = searchQuery;
            filter.Page = page;
            filter.RecordsPerPage = rpp;
            filter.SortBy = sortBy;
            filter.SortAscending = sortAsc;
            return Mapper.Map<PaginatedList<StepViewModel>>(await Service.FindAsync(Mapper.Map<IStepFilter>(filter)));
        }

        // GET: api/<controller>
        [HttpGet("{id}")]
        public async Task<StepViewModel> GetAsync(Guid id)
        {
            return Mapper.Map<StepViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<StepViewModel> PostAsync([FromBody]StepViewModel step)
        {
            return Mapper.Map<StepViewModel>(await Service.CreateAsync(Mapper.Map<IStep>(step)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public async Task<bool> PutAsync(StepViewModel value, [FromRoute]Guid id)
        {
            value.Id = id;
            return await Service.UpdateAsync(Mapper.Map<IStep>(value));
        }

        #endregion Methods
    }
}