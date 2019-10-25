using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    internal class MembershipService : IMembershipService
    {
        #region Constructors

        public MembershipService(IMembershipRepository membershipRepository)
        {
            MembershipRepository = membershipRepository;
        }

        #endregion Constructors

        #region Properties

        protected IMembershipRepository MembershipRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<IMembership> CreateAsync(IMembership membership)
        {
            return MembershipRepository.CreateAsync(membership);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return MembershipRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<IMembership>> FindAsync(IMembershipFilter filter)
        {
            return MembershipRepository.FindAsync(filter);
        }

        public Task<IMembership> GetAsync(Guid id)
        {
            return MembershipRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(IMembership membership)
        {
            return MembershipRepository.UpdateAsync(membership);
        }

        #endregion Methods
    }
}