using fakeLook_dal.Data;
using fakeLook_models.Models;
using fakeLook_starter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fakeLook_starter.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly private DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> Add(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            var userDb = GetUser(user);
            return userDb;
        }
        public async Task<User> Change(User user)
        {
            var dbUser = _context.Users.SingleOrDefault(u => u.Name == user.Name);
            dbUser.Password = user.Password;
            _context.Users.Update(dbUser);
            await _context.SaveChangesAsync();
            return dbUser;
        }
        public async Task<User> Edit(User item)
        {
            var res = _context.Users.Update(item);
            await _context.SaveChangesAsync();
            return res.Entity;
        }

        public ICollection<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.SingleOrDefault(p => p.Id == id);
        }

        public  User GetUser(User user)
        {
            return _context.Users.SingleOrDefault(p => ((p.Name == user.Name) && (p.Password == user.Password)));
        }

        public ICollection<User> GetByPredicate(Func<User, bool> predicate)
        {
            return _context.Users.Where(predicate).ToList();
        }

        public bool UserExists(User user)
        {
            return _context.Users.Any(u => u.Name == user.Name);
        }

    }
}
