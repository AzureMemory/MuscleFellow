using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuscleFellow.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            base.Id = new Guid().ToString();
        }
    }
}
