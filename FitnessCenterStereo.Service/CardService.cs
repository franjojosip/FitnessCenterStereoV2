using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Threading.Tasks;

namespace FitnessCenterStereo.Service
{
    public class CardService : ICardService
    {
        #region Constructors

        public CardService(ICardRepository cardRepository)
        {
            CardRepository = cardRepository;
        }

        #endregion Constructors

        #region Properties

        public ICardRepository CardRepository { get; private set; }

        #endregion Properties

        #region Methods

        public Task<ICard> CreateAsync(ICard card)
        {
            return CardRepository.CreateAsync(card);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return CardRepository.DeleteAsync(id);
        }

        public Task<PaginatedList<ICard>> FindAsync(ICardFilter filter)
        {
            return CardRepository.FindAsync(filter);
        }

        public Task<ICard> GetAsync(Guid id)
        {
            return CardRepository.GetAsync(id);
        }

        public Task<bool> UpdateAsync(ICard card)
        {
            return CardRepository.UpdateAsync(card);
        }

        #endregion Methods
    }
}