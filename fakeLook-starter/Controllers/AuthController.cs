using auth_example.Interfaces;
using fakeLook_dal.Data;
using fakeLook_models.Models;
using fakeLook_starter.Interfaces;
using fakeLook_starter.Repositories;
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
    public class AuthController : Controller
    {
        private readonly IUserRepository _repo;
        private ITokenService _tokenService { get; }

        public AuthController(IUserRepository repo,ITokenService tokenService)
        {
            _repo = repo;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] User user)
        {
            var dbUser = _repo.GetUser(user);
            if (dbUser == null) return Problem("user not in system");
            var token = _tokenService.CreateToken(user);
            var id = dbUser.Id;
            return Ok(new { token ,id });
        }

        [HttpPost]
        [Route("SignUp")]
        public IActionResult SignUp([FromBody] User user)
        {
            if (_repo.UserExists(user))
            {
                return Problem("user name exists");
            }
            var dbUser = _repo.Add(user);
            if (dbUser == null) return Problem("user signup failed");
            var token = _tokenService.CreateToken(user);
            var id = dbUser.Id;
            return Ok(new { token, id });
        }

        [Authorize]
        [HttpGet]
        [Route("TestAll")]

        public IActionResult TestAll()
        {
            return Ok(true);
        }


    }
}
