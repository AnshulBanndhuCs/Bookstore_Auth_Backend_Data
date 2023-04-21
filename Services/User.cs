using BookStore_Auth_Backend_API_DataAccess.Identity;
using BookStore_Auth_Backend_API_DataAccess.ServiceContract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Auth_Backend_API_DataAccess.Services
{
    public class User:IUser
    {
        private readonly ApplicationDbContext _context;
        public User(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BookStore_Auth_Backend_API_Models.Models.User> AddUserAsync(BookStore_Auth_Backend_API_Models.Models.User user)
        {
            if (user != null)
            {
                await _context.users.AddAsync(user);
                await _context.SaveChangesAsync();
                return user;
            }
            return null;
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            var userFromDb = await GetUserByIdAsync(userId);
            if (userFromDb != null)
            {
                _context.users.Remove(userFromDb);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<BookStore_Auth_Backend_API_Models.Models.User>> GetAllUserAsync()
        {
            return await _context.users.ToListAsync();
        }

        public async Task<BookStore_Auth_Backend_API_Models.Models.User> GetUserByIdAsync(int userId)
        {
            return await _context.users.FindAsync(userId);
        }

        public async Task<BookStore_Auth_Backend_API_Models.Models.User> UpdateUserAsync(int userId, BookStore_Auth_Backend_API_Models.Models.User user)
        {
            var userInDb = await _context.users.FindAsync(userId);
            if (userInDb != null)
            {
                userInDb.userName = user.userName;
                userInDb.email = user.email;
                userInDb.contact = user.contact;
                await _context.SaveChangesAsync();
                return userInDb;
            }
            return null;
        }

        public async Task<bool> UserExistsAsync(int userId)
        {
            return await _context.users.AnyAsync(u => u.id == userId);
        }
    }
}
