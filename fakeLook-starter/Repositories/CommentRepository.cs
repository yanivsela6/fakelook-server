﻿using fakeLook_models.Models;
using fakeLook_starter.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fakeLook_starter.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        public Task<Comment> Add(Comment item)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> Edit(Comment item)
        {
            throw new NotImplementedException();
        }

        public ICollection<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Comment> GetByPredicate(Func<Comment, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
