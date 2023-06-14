using LevvaCoins.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevvaCoins.IoC
{
    public static class DependencyInjector
    {

            public static void AddNewbiesService(this IServiceCollection services, IConfiguration configuration)
            {
                services.AddDbContext<Context>(options => options.UseSqlite(configuration.GetConnectionString("Default"), b => b.MigrationsAssembly("Levva.Newbies.Coins")));
                //services.AddAutoMapper(typeof(DefaultMapper));

                //services.AddScoped<IUsuarioRepository, UsuarioRepository>();
                //services.AddScoped<ITransacaoRepository, TransacaoRepository>();
                //services.AddScoped<ICategoriaRepository, CategoriaRepository>();

                //services.AddScoped<IUsuarioService, UsuarioService>();
                //services.AddScoped<ITransacaoService, TransacaoService>();
                //services.AddScoped<ICategoriaService, CategoriaService>();
            }
        
    }
}
