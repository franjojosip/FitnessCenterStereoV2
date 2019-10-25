using System;

namespace FitnessCenterStereo.Model.Common
{
    public interface ICard : IBaseModel
    {
        #region Properties

        Guid MembershipId { get; set; }
        String UserId { get; set; }

        #endregion Properties
    }
}