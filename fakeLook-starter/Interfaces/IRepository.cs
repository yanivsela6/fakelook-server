using fakeLook_models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fakeLook_starter.Interfaces
{
    public interface IRepository<T>
    {
        public Task<T> Add(T item);
        public ICollection<T> GetAll();
        public Task<T> Edit(T item);
        public T GetById(int id);
        public ICollection<T> GetByPredicate(Func<T, bool> predicate);
    }
    public interface IUserRepository : IRepository<User>
    {
        public User GetUser(User user);
        public bool UserExists(User user);
        public Task<User> Change(User user);





    }
    public interface IPostRepository : IRepository<Post>
    {
        public Task<Post> Delete(int id);
        public Task<Like> EditLike(int id);

        public Task<Like> AddLike(Like item);
        public Task<Comment> AddComment(Comment item);
        public Task<Tag> AddTag(Tag item);

    }
}
