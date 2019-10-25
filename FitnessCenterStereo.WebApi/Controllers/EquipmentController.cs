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
    public class EquipmentController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public EquipmentController(IEquipmentService service, IMapper mapperInterface, IFacadeFilter filter) : base()
        {
            Service = service;
            mapper = mapperInterface;
            Filter = filter;
        }

        #endregion Constructors

        #region Properties

        protected IFacadeFilter Filter { get; private set; }
        protected IEquipmentService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(Guid id)
        {
            return await Service.DeleteAsync(id);
        }

        public async Task<PaginatedList<EquipmentViewModel>> FindAsync(string searchQuery = DefaultSearchQuery, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IEquipmentFilter filter = Filter.CreateEquipmentFilter();
            filter.SearchQuery = searchQuery;
            filter.Page = page;
            filter.RecordsPerPage = rpp;
            filter.SortBy = sortBy;
            filter.SortAscending = sortAsc;
            return mapper.Map<PaginatedList<EquipmentViewModel>>(await Service.FindAsync(mapper.Map<IEquipmentFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public async Task<EquipmentViewModel> GetAsync(Guid id)
        {
            return mapper.Map<EquipmentViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<EquipmentViewModel> PostAsync([FromBody]EquipmentViewModel value)
        {
            return mapper.Map<EquipmentViewModel>(await Service.CreateAsync(mapper.Map<IEquipment>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public async Task<bool> PutAsync([FromBody]EquipmentViewModel value, [FromRoute]Guid id)
        {
            value.Id = id;
            return await Service.UpdateAsync(mapper.Map<IEquipment>(value));
        }

        #endregion Methods
    }
}