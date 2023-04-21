using BookStore_Auth_Backend_API_Models.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Auth_Backend_API_DataAccess.ServiceContract
{
    public interface IUser
    {
        Task<List<User>> GetAllUserAsync();
        Task<User> GetUserByIdAsync(int userId);
        Task<User> AddUserAsync(User user);
        Task<bool> UserExistsAsync(int userId);
        Task<bool> DeleteUserAsync(int userId);
        Task<User> UpdateUserAsync(int userId, User user);
    }
}
