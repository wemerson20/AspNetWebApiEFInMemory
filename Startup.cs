using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Web_api_EF_in_memory.Models;

namespace Web_api_EF_in_memory
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("ApiDbContext"));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            var context = app.ApplicationServices.GetService<ApiContext>();
            InicializaBanco(context);
        }

        private static void InicializaBanco(ApiContext context)
        {
            var vendaTeste1 = new Venda
            {
            };

            context.Vendas.Add(vendaTeste1);

            var vendedor1 = new Vendedor
            {
                Codigo = 1,
                Nome = "Joao",
                Cpf = "90306862000"
            };

            var vendedor2 = new Vendedor
            {
                Codigo = 2,
                Nome = "José",
                Cpf = "14035058025"
            };

            context.Vendedores.Add(vendedor1);
            context.Vendedores.Add(vendedor2);

            context.SaveChanges();
        }
    }
}
