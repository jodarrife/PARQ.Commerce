using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain
{
    public class ApplicationUser : IdentityUser { 
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
