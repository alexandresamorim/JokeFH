
using JokeFH.Aplicacao.Interface;
using JokeFH.Aplicacao.Services;
using JokeFH.Dominio.Interface.Repository;
using JokeFH.Dominio.Interface.Service;
using JokeFH.Dominio.Service;
using JokeFH.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace JokeFH.Infra.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Dominio
            services.AddScoped<IHistoricoService, HistoricoService>();

            //Infra Data
            services.AddScoped<IHistoricoRepository, HistoricoRepository>();

            //Aplicação
            services.AddScoped<IHistoricoAppService, HistoricoAppService>();
        }
    }
}