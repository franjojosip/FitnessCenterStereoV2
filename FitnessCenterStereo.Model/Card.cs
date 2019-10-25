using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class Card : BaseModel, ICard
    {
        #region Properties

        public Guid MembershipId { get; set; }
        public string UserId { get; set; }

        #endregion Properties
    }
}