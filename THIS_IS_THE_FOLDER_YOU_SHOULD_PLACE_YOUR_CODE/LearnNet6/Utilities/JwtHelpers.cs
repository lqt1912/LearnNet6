using LearnNet6.Data.Entity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LearnNet6.Utilities
{
    /// <summary>
    /// JWt Utilities helper.
    /// </summary>
    public static class JwtHelpers
    {
        /// <summary>
        /// Creates the token.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="claims">The claims.</param>
        /// <returns></returns>
        public static string CreateToken(IConfiguration configuration, Claim[] claims)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtKey = Encoding.UTF8.GetBytes(configuration["Jwt:Issuer"]);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(configuration.GetValue<int>("Jwt:ExpiredTime")),
                Audience = configuration["Jwt:Issuer"],
                Issuer = configuration["Jwt:Issuer"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(jwtKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        /// <summary>
        /// Gets the new refresh token.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public static RefreshToken GetNewRefreshToken(IConfiguration configuration, Guid userId)
        {
            var randomGuid = Guid.NewGuid();
            var tokenValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(randomGuid.ToString()));
            var refreshToken = new RefreshToken()
            {
                CreatedDate = DateTime.UtcNow,
                ExpiredDate = DateTime.UtcNow.AddDays(configuration.GetValue<int>("Jwt:ExpiredRefreshToken")),
                Value = tokenValue, 
                UserId = userId
            };
            return refreshToken;  


        }

        public static string DecodeJwt(string token)
        {
       
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            var result = jwtSecurityToken.Claims.First(x => x.Type == "oid").Value;
            return result;
        }
    }
}
