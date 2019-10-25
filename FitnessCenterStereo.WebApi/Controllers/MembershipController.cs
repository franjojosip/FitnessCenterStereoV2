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
    public class MembershipController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public MembershipController(IMembershipService service, IMapper mapperInterface, IFacadeFilter filter) : base()
        {
            Service = service;
            mapper = mapperInterface;
            Filter = filter;
        }

        #endregion Constructors

        #region Properties

        protected IFacadeFilter Filter { get; private set; }
        protected IMembershipService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public Task<bool> DeleteAsync(Guid id)
        {
            return Service.DeleteAsync(id);
        }

        public async Task<PaginatedList<MembershipViewModel>> FindAsync(string searchQuery = DefaultSearchQuery, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IMembershipFilter filter = Filter.CreateMembershipFilter();
            filter.SearchQuery = searchQuery;
            filter.Page = page;
            filter.RecordsPerPage = rpp;
            filter.SortBy = sortBy;
            filter.SortAscending = sortAsc;
            return mapper.Map<PaginatedList<MembershipViewModel>>(await Service.FindAsync(mapper.Map<IMembershipFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public async Task<MembershipViewModel> GetAsync(Guid id)
        {
            return mapper.Map<MembershipViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<MembershipViewModel> PostAsync([FromBody]MembershipViewModel value)
        {
            return mapper.Map<MembershipViewModel>(await Service.CreateAsync(mapper.Map<IMembership>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public async Task<bool> PutAsync([FromBody]MembershipViewModel value, [FromRoute]Guid id)
        {
            value.Id = id;
            return await Service.UpdateAsync(mapper.Map<IMembership>(value));
        }

        #endregion Methods
    }
}