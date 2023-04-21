using BookStore_Auth_Backend_API_DataAccess.Identity;
using BookStore_Auth_Backend_API_DataAccess.ServiceContract;
using BookStore_Auth_Backend_API_Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Auth_Backend_API_DataAccess.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationUserManager _applicationUserManager;
        private readonly ApplicationSignInManager _applicationSignInManager;
        public UserService(ApplicationUserManager applicationUserManager, ApplicationSignInManager applicationSignInManager)
        {
            _applicationUserManager = applicationUserManager;
            _applicationSignInManager = applicationSignInManager;
        }

        public async Task<ApplicationUser> Authenticate(LoginVM loginVM)
        {
            var result = await _applicationSignInManager.PasswordSignInAsync(loginVM.userName, loginVM.password, false, false);
            // to solve the Method not found: 'Boolean Microsoft.AspNetCore.Cryptography.UnsafeNativeMethods.CryptProtectData
            // install:- <PackageReference Include="Microsoft.AspNetCore.DataProtection" Version="7.0.5" />
            if (result.Succeeded)
            {
                var applicationUser = await _applicationUserManager.FindByNameAsync(loginVM.userName); //Find the information of the user based on username!
                applicationUser.PasswordHash = "";
                //JWT

                return applicationUser;
            }
            else
            {
                return null;
            }
        }
    }
}
