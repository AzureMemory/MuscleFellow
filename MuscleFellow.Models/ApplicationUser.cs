using System;
using System.Collections.Generic;
using System.Text;

namespace MuscleFellow.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            base.Id = new Guid();
        }
    }
}
