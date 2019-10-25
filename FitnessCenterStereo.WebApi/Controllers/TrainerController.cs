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
    public class TrainerController : BaseApiController
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public TrainerController(ITrainerService service, IMapper mapper, IFacadeFilter filter)
        {
            Mapper = mapper;
            Service = service;
            Filter = filter;
        }

        #endregion Constructors

        #region Properties

        protected IFacadeFilter Filter { get; private set; }
        protected ITrainerService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(Guid id)
        {
            return await Service.DeleteAsync(id);
        }

        [HttpGet]
        public async Task<PaginatedList<TrainerViewModel>> FindAsync(string searchQuery = DefaultSearchQuery, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            ITrainerFilter filter = Filter.CreateTrainerFilter();
            filter.SearchQuery = searchQuery;
            filter.Page = page;
            filter.RecordsPerPage = rpp;
            filter.SortBy = sortBy;
            filter.SortAscending = sortAsc;
            return Mapper.Map<PaginatedList<TrainerViewModel>>(await Service.FindAsync(Mapper.Map<ITrainerFilter>(filter)));
        }

        // GET: api/<controller>
        [HttpGet("{id}")]
        public async Task<TrainerViewModel> GetAsync(Guid id)
        {
            return Mapper.Map<TrainerViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<TrainerViewModel> PostAsync([FromBody]TrainerViewModel trainer)
        {
            return Mapper.Map<TrainerViewModel>(await Service.CreateAsync(Mapper.Map<ITrainer>(trainer)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public async Task<bool> PutAsync(TrainerViewModel value, [FromRoute]Guid id)
        {
            value.Id = id;
            return await Service.UpdateAsync(Mapper.Map<ITrainer>(value));
        }

        #endregion Methods
    }
}