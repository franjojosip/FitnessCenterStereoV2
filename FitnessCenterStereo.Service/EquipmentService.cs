using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    public class EquipmentService : IEquipmentService
    {
        #region Constructors

        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            EquipmentRepository = equipmentRepository;
        }

        #endregion Constructors

        #region Properties

        protected IEquipmentRepository EquipmentRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<IEquipment> CreateAsync(IEquipment equipment)
        {
            return EquipmentRepository.CreateAsync(equipment);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return EquipmentRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<IEquipment>> FindAsync(IEquipmentFilter filter)
        {
            return EquipmentRepository.FindAsync(filter);
        }

        public Task<IEquipment> GetAsync(Guid id)
        {
            return EquipmentRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(IEquipment equipment)
        {
            return EquipmentRepository.UpdateAsync(equipment);
        }

        #endregion Methods
    }
}