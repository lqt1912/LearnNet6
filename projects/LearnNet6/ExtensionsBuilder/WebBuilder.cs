using FluentValidation.AspNetCore;
using LearnNet6.Data.Repositories;
using LearnNet6.Mappers;
using LearnNet6.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc.Versioning;
using System.Reflection;

namespace LearnNet6.ExtensionsBuilder
{
    public static class WebBuilder
    {
        public static WebApplicationBuilder CreateBuilder(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.AddDatabase();
            builder.Services.AddControllersWithViews();
            builder.Services.AddFluentValidation();
            builder.Services.AddCustomRepository();
            builder.Services.AddCustomExtensions();
            //builder.Services.Configure<NCacheConfiguration>(builder.Configuration.GetSection("NCacheConfiguration"));
            builder.Services.AddSignalR(options =>
            {
                options.EnableDetailedErrors = true;
            });
            builder.AddAuthentication();

            builder.Services.AddAuthorization();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddApiVersioning(opt =>
            {
                opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.ReportApiVersions = true;
                opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                                new HeaderApiVersionReader("x-api-version"),
                                                                new MediaTypeApiVersionReader("x-api-version"));
            });
            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
            builder.AddSwaggerEx();
            builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
            builder.Services.AddCors();


            return builder;
        }
    }
}
