using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace aspDotNet.EntityLayer.Concrate
{
    public class appUser:IdentityUser<int>
    {
        public string appUserName { get; set; }

        public string appUserSurname { get; set; }

        public string appUserDistrict { get; set; }

        public string appUserCity { get; set; }

        public string appUserImageUrl { get; set; }

        public List<CustommerAccount> CustommerAccounts { get; set; }
    }
}
