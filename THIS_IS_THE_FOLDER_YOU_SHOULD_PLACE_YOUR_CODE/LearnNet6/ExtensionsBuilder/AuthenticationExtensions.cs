using LearnNet6.Data;
using LearnNet6.Data.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace LearnNet6.ExtensionsBuilder
{
    public static class AuthenticationExtensions
    {
        public static void AddAuthentication(this WebApplicationBuilder builder)
        {
            var configuration = builder.Configuration;

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //builder.Services.AddAuthentication().AddJwtBearer(o =>
            //{
            //    o.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidIssuer = configuration["Jwt:Issuer"],
            //        ValidAudience = configuration["Jwt:Audience"],
            //        IssuerSigningKey = new SymmetricSecurityKey
            //            (Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidateLifetime = false,
            //        ValidateIssuerSigningKey = true
            //    };
            //});

            builder.Services.AddMicrosoftIdentityWebApiAuthentication(builder.Configuration);
        }
    }
}
