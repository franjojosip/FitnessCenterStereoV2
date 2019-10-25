using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IMembershipRepository : IRepository<IMembership, IMembershipFilter>
    {
    }
}