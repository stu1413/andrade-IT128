using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProjMgmtDataLibrary.Data;
using ProjMgmtDataLibrary.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json.Nodes;
using System.Text;
using System.Numerics;

namespace ProjMgmtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private ISqlData _db;

        public LoginController(IConfiguration config, ISqlData db)
        {
            _config = config;
            _db = db;
        }

        private string GenerateToken(EmployeeModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            string userIdStr = user.Id.ToString();
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userIdStr),
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/api/[controller]/login")]
        public ActionResult Login([FromBody] UserLogin login)
        {
            EmployeeModel user = _db.Authenticate(login.Email, login.Password);

            if (user != null)
            {
                var token = GenerateToken(user);

                JsonObject loginData = new JsonObject();
                loginData.Add("id_token", token);
                loginData.Add("id", user.Id);

                return Ok(loginData);
            }

            return NotFound("User not found");
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/api/[controller]/register")]
        public ActionResult Register([FromBody] EmployeeModel employee)
        {
            employee.DateHired = DateTime.Now;

            _db.Register(employee.Email, employee.Password, employee.FirstName, employee.LastName, employee.RoleId, employee.DepartmentId, employee.RegionId, employee.Phone, employee.DateHired);
            return Ok("User registered.");
        }


    }
}

