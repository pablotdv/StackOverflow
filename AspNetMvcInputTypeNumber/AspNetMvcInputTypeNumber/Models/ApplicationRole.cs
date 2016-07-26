using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace IdentitySample.Models
{
    public class ApplicationRole : IdentityRole<Guid, ApplicationUserRole>
    {
        public ApplicationRole()
        {
            Id = Guid.NewGuid();
        }
    }
}