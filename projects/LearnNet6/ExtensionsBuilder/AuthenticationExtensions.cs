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

            

            //builder.Services.AddMicrosoftIdentityWebApiAuthentication(builder.Configuration);

            //builder.Services.AddAuthentication(x =>
            //{
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(x =>
            //{
            //    x.Authority = "https://login.microsoftonline.com/5d0bab8d-cd6a-40ec-a09b-2e2308defc9d/oauth2/v2.0";
            //    x.Audience = "c026de13-f3bd-4200-a8cf-e21b69abd736";
            //    x.SaveToken = true;
            //    x.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = false,
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //    };
            //});

        }
    }
}
