using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FoundryWebAPI.Models;
using Microsoft.IdentityModel.Tokens;

namespace FoundryWebAPI.Services
{
    /// <summary>
    /// 
    ///</summary>
    /// <returns></returns>
    public static class TokenService
    {
        /// <summary>
        /// 
        ///</summary>
        /// <returns></returns>
        public static string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name, user.Username.ToString()) }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}