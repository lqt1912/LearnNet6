using FluentValidation.AspNetCore;
using LearnNet6.Data.Repositories;
using LearnNet6.Mappers;
using LearnNet6.Services;
using MediatR;
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
            builder.Services.AddSignalR();
            builder.AddAuthentication();

            builder.Services.AddAuthorization();
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
            builder.AddSwaggerEx();
            builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
            builder.Services.AddCors();


            return builder;
        }
    }
}
