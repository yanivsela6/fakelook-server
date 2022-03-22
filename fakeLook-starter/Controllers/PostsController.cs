using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using fakeLook_dal.Data;
using fakeLook_models.Models;
using fakeLook_starter.Interfaces;

namespace fakeLook_starter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _repository;

        public PostsController(IPostRepository repo)
        {
            _repository = repo;
        }

        // GET: api/Posts
        [HttpGet]
        public IEnumerable<Post> GetPosts()
            
        {
            return  _repository.GetAll();
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public Post GetPost(int id)
        {
            var post = _repository.GetById(id);
            if (post == null)
            {
                return null;
            }

            return post;
        }

        // GET: api/Posts/filter/
        [HttpPost]
        [Route("filter")]
        public IEnumerable<Post> PostFilter(FiltersModel filters)
        {
            IEnumerable<Post> postsList = _repository.GetAll();
            if (filters.DateFrom.HasValue && filters.DateTo.HasValue)
            {
                postsList = postsList.Where(d => ((d.Date >= filters.DateFrom) && (d.Date <= filters.DateTo)));
            }
            if (filters.Publishers[0] != "")
            {
                //TODO convert array to hash map
                    postsList = postsList.Where(u=>filters.Publishers.Contains(u.User.Name));
            }
            if (filters.Tags[0] != "")
            {
                postsList = postsList.Where(t => t.Tags.Any(u => filters.Tags.Contains(u.Content)));   
            }
            if (filters.TagsUsers[0] != "")
            {
                postsList = postsList.Where(t => t.UserTaggedPost.Any(u => filters.TagsUsers.Contains(u.User.Name)));
            }

            return postsList.ToList();
        }

        // PUT: api/Posts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(int id, Post post)
        {
            if (id != post.Id)
            {
                
                return BadRequest();
            }

            await _repository.Edit(post);
            return NoContent();
        }

        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post post)
        {
           await _repository.Add(post);

            return CreatedAtAction("GetPost", new { id = post.Id }, post);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _repository.Delete(id);
            if (post == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
