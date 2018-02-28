using Kondominium.Domain.CommandsServices;
using Kondominium.Domain.Interfaces.Repositories;
using Kondominium.RepositoryBase.Context;
using Kondominium.RepositoryBase.Repositories;
using Kondominium.RepositoryBase.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;

namespace Kondominium.API
{
    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            var configurationBuilder = new ConfigurationBuilder()
              .SetBasePath(env.ContentRootPath)
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .AddEnvironmentVariables();

            Configuration = configurationBuilder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });


            services.AddCors();
            ;
            services.AddSwaggerGen(
                c =>
                {
                    c.SwaggerDoc("v1", new Info { Title = "SysRestaurante", Description = "API SysyRestaurante", Version = "v1" });
                }
            );

            services.AddScoped<KondominiumContext, KondominiumContext>();
            services.AddTransient<IUow, Uow>();

            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddTransient<IApartamentoRepository, ApartamentoRepository>();
            services.AddTransient<ICondominioRepository, CondominioRepository>();
            services.AddTransient<IBlocoRepository, BlocoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            services.AddTransient<ApartamentoListService, ApartamentoListService>();
            services.AddTransient<ApartamentoSaveService, ApartamentoSaveService>();
            services.AddTransient<BlocoListService, BlocoListService>();
            services.AddTransient<BlocoSaveService, BlocoSaveService>();
            services.AddTransient<CondominioListService, CondominioListService>();
            services.AddTransient<CondominioSaveService, CondominioSaveService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x =>
            {
                x.AllowAnyHeader();
                x.AllowAnyMethod();
                x.AllowAnyOrigin();
            });
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "SysRestaurante"); });

        }
    }
}
