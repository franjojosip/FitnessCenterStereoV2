using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    internal class DietTypeService : IDietTypeService
    {
        #region Constructors

        public DietTypeService(IDietTypeRepository dietTypeRepository)
        {
            DietTypeRepository = dietTypeRepository;
        }

        #endregion Constructors

        #region Properties

        protected IDietTypeRepository DietTypeRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<IDietType> CreateAsync(IDietType dietType)
        {
            return DietTypeRepository.CreateAsync(dietType);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return DietTypeRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<IDietType>> FindAsync(IDietTypeFilter filter)
        {
            return DietTypeRepository.FindAsync(filter);
        }

        public Task<IDietType> GetAsync(Guid id)
        {
            return DietTypeRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(IDietType dietType)
        {
            return DietTypeRepository.UpdateAsync(dietType);
        }

        #endregion Methods
    }
}