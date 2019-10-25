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
    public class ScheduleController : BaseApiController
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public ScheduleController(IScheduleService service, IMapper mapper, IFacadeFilter filter)
        {
            Service = service;
            Mapper = mapper;
            Filter = filter;
        }

        #endregion Constructors

        #region Properties

        protected IFacadeFilter Filter { get; private set; }
        protected IScheduleService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(Guid id)
        {
            return await Service.DeleteAsync(id);
        }

        [HttpGet]
        public async Task<PaginatedList<ScheduleViewModel>> FindAsync(string searchQuery = DefaultSearchQuery, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IScheduleFilter filter = Filter.CreateScheduleFilter();
            filter.SearchQuery = searchQuery;
            filter.Page = page;
            filter.RecordsPerPage = rpp;
            filter.SortBy = sortBy;
            filter.SortAscending = sortAsc;
            return Mapper.Map<PaginatedList<ScheduleViewModel>>(await Service.FindAsync(Mapper.Map<IScheduleFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public async Task<ScheduleViewModel> GetAsync(Guid id)
        {
            return Mapper.Map<ScheduleViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ScheduleViewModel> PostAsync([FromBody] ScheduleViewModel value)
        {
            return Mapper.Map<ScheduleViewModel>(await Service.CreateAsync(Mapper.Map<ISchedule>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public async Task<bool> PutAsync(ScheduleViewModel value, [FromRoute]Guid id)
        {
            value.Id = id;
            return await Service.UpdateAsync(Mapper.Map<ISchedule>(value));
        }

        #endregion Methods
    }
}