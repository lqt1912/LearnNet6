using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace LearnNet6.ExtensionsBuilder
{
    public static class AuthenticationExtensions
    {
        public static void AddAuthentication(this WebApplicationBuilder builder)
        {
            builder.Services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = "ikoafhqiuoefhewouiqdfhiuosdfsdfsdfsdf",
                    ValidAudience = "ikoafhqiuoefhewouiqdfhiuosdfsdfsdfsdf",
                    IssuerSigningKey = new SymmetricSecurityKey
                        (Encoding.UTF8.GetBytes("ikoafhqiuoefhewouiqdfhiuosdfsdfsdfsdf")),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true
                };
            });
        }
    }
}
