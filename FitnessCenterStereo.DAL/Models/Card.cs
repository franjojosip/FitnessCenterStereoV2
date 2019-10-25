using Microsoft.AspNetCore.Identity;
using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Card : BaseModel
    {
        #region Properties

        public Guid? MembershipId { get; set; }
        public virtual IdentityUser User { get; set; }
        public string UserId { get; set; }

        #endregion Properties
    }
}