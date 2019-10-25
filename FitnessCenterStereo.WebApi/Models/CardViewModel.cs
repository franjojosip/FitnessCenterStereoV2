using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public class CardViewModel : BaseViewModel
    {
        #region Properties

        public Guid MembershipId { get; set; }
        public string UserId { get; set; }

        #endregion Properties
    }
}