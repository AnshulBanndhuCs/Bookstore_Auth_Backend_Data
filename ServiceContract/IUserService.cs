using BookStore_Auth_Backend_API_DataAccess.Identity;
using BookStore_Auth_Backend_API_Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Auth_Backend_API_DataAccess.ServiceContract
{
    public interface IUserService
    {
        Task<ApplicationUser> Authenticate(LoginVM loginVM);
    }
}
