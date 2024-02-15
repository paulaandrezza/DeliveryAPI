using DeliveryAPI.RequestModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(LoginRequest loginRequest)
        {
            try
            {
                if (string.IsNullOrEmpty(loginRequest.UserName) ||
                string.IsNullOrEmpty(loginRequest.Password))
                    return BadRequest("Username and/or Password not specified");
                if (loginRequest.UserName.Equals("admin") &&
                loginRequest.Password.Equals("admin123"))
                {
                    var secretKey = new SymmetricSecurityKey
                    (Encoding.UTF8.GetBytes("thisisasecretkey@12345678901234567890"));
                    var signinCredentials = new SigningCredentials
                    (secretKey, SecurityAlgorithms.HmacSha256);
                    var jwtSecurityToken = new JwtSecurityToken(
                        issuer: "ABCXYZ",
                        audience: "http://localhost:51398",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(10),
                        signingCredentials: signinCredentials
                    );
                    return Ok(new JwtSecurityTokenHandler().
                    WriteToken(jwtSecurityToken));
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred in generating the token: {ex}");
            }
            return Unauthorized();
        }
    }
}
