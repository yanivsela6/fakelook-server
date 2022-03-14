using auth_example.Interfaces;
using fakeLook_dal.Data;
using fakeLook_models.Models;
using fakeLook_starter.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auth_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _repo;
        private ITokenService _tokenService { get; }

        public AuthController(DataContext repo,ITokenService tokenService)
        {
            _repo = repo;
            _tokenService = tokenService;
        }


        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<User>> Login(User user)
        {
            var dbUser =  _repo.Users.Where(a => a.Name.Equals(user.Name) && a.Password.Equals(user.Password)).FirstOrDefault();
            if (dbUser == null) return Problem("user not in system");
            var token = _tokenService.CreateToken(dbUser);
            return Ok(new { token });
        }

        [HttpPost]
        [Route("SignUp")]
        public IActionResult SignUp([FromBody] User user)
        {
            if (UserExists(user))
            {
                return Problem("user name exists");
            }
            var dbUser = _repo.Users.Add(user);
            _repo.SaveChanges();
            var token = _tokenService.CreateToken(user);
            return Ok(new { token });
        }

        [Authorize]
        [HttpGet]
        [Route("TestAll")]

        public IActionResult TestAll()
        {
            return Ok();
        }


        private bool UserExists(User user)
        {
            return _repo.Users.Any(u => u.Name == user.Name);
        }

    }
}
