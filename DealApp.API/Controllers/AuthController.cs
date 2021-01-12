using DealApp.API.Data;
using DealApp.API.Dtos;
using DealApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using System;
using System.IdentityModel.Tokens.Jwt;

namespace DealApp.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            _config = config;
            _repo = repo;
        }

        // Register
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            // validate request

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if(await _repo.UserExists(userForRegisterDto.Username))
            return BadRequest("Username already exists");

            //creating the user (in this stage we can only set the username of the User)
            var userToCreate = new User{
                Username = userForRegisterDto.Username
            };

            // we will generate the passwordHash and the passwordSalt for the Usder..
            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }


        // Login
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userFromRepo = await _repo.Login(userForLoginDto.Username.ToLower(), userForLoginDto.Password);
            
            if(userFromRepo == null)
               return Unauthorized();

            // Generating the token..
            // taking minimum info from the user...
            var claims = new[]
            {
               new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
               new Claim(ClaimTypes.Name,userFromRepo.Username)
            };
            // Generating the security key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("Appsettings:Token").Value));
            // Hashing the security key
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDesciptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            // Creating token..
            var token = tokenHandler.CreateToken(tokenDesciptor);

            // sending our token as object to the client respond
            return Ok(new{
                token = tokenHandler.WriteToken(token)
            });
        }
    }
}