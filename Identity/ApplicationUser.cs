using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Auth_Backend_API_DataAccess.Identity
{
    public class ApplicationUser:IdentityUser
    {
        [NotMapped]
        public string token { get; set; }
        [NotMapped]
        public string role { get; set; }
    }
}
