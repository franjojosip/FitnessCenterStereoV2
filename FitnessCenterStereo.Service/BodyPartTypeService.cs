using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    public class BodyPartTypeService : IBodyPartTypeService
    {
        #region Constructors

        public BodyPartTypeService(IBodyPartTypeRepository bodyPartTypeRepository)
        {
            BodyPartTypeRepository = bodyPartTypeRepository;
        }

        #endregion Constructors

        #region Properties

        protected IBodyPartTypeRepository BodyPartTypeRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<IBodyPartType> CreateAsync(IBodyPartType bodyPartType)
        {
            return BodyPartTypeRepository.CreateAsync(bodyPartType);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return BodyPartTypeRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<IBodyPartType>> FindAsync(IBodyPartTypeFilter filter)
        {
            return BodyPartTypeRepository.FindAsync(filter);
        }

        public Task<IBodyPartType> GetAsync(Guid id)
        {
            return BodyPartTypeRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(IBodyPartType bodyPartType)
        {
            return BodyPartTypeRepository.UpdateAsync(bodyPartType);
        }

        #endregion Methods
    }
}