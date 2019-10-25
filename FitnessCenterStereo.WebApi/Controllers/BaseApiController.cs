using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : Controller
    {
        #region Fields

        protected const int DefaultPage = 1;
        protected const int DefaultRpp = 10;
        protected const string DefaultSearchQuery = "";
        protected const bool DefaultSortAsc = true;
        protected const string DefaultSortBy = "dateUpdated";

        #endregion Fields
    }
}