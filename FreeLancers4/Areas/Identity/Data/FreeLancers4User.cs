using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FreeLancers4.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the FreeLancers4User class
    public class FreeLancers4User : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public string Proffesion { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

        [PersonalData]
        public string Role { get; set; }

    }
}
