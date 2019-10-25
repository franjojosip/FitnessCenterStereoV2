using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    internal class ComplexityLevelTypeService : IComplexityLevelTypeService
    {
        #region Constructors

        public ComplexityLevelTypeService(IComplexityLevelTypeRepository complexityLevelTypeRepository)
        {
            ComplexityLevelTypeRepository = complexityLevelTypeRepository;
        }

        #endregion Constructors

        #region Properties

        protected IComplexityLevelTypeRepository ComplexityLevelTypeRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<IComplexityLevelType> CreateAsync(IComplexityLevelType complexityLevel)
        {
            return ComplexityLevelTypeRepository.CreateAsync(complexityLevel);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return ComplexityLevelTypeRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<IComplexityLevelType>> FindAsync(IComplexityLevelTypeFilter filter)
        {
            return ComplexityLevelTypeRepository.FindAsync(filter);
        }

        public Task<IComplexityLevelType> GetAsync(Guid id)
        {
            return ComplexityLevelTypeRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(IComplexityLevelType complexityLevel)
        {
            return ComplexityLevelTypeRepository.UpdateAsync(complexityLevel);
        }

        #endregion Methods
    }
}