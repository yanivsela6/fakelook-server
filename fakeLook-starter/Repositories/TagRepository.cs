using fakeLook_dal.Data;
using fakeLook_models.Models;
using fakeLook_starter.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fakeLook_starter.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        readonly private DataContext _context;
        public TagRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Tag> Add(Tag item)
        {
            var res = _context.Tags.Add(item);
            await _context.SaveChangesAsync();
            return res.Entity;
        }

        public Task<Tag> Edit(Tag item)
        {
            throw new NotImplementedException();
        }

        public ICollection<Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tag GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Tag> GetByPredicate(Func<Tag, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
