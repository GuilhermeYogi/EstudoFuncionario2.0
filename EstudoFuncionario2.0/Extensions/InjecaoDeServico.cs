using EstudoFuncionario2._0.Controllers;
using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Repositories;
using EstudoFuncionario2._0.Services;

namespace EstudoFuncionario2._0.Extensions
{
    public static class InjecaoDeServicos
    {
        public static void AddMyServices(this IServiceCollection services, IConfiguration _configuration)
        {
            services.AddTransient<FuncionariosRepository>();
            services.AddTransient<IFuncionariosService, FuncionariosService>();
            services.AddTransient<VisualizaFuncionarioRepository>();
            services.AddTransient<IVisualizaFuncionarioService, VisualizaFuncionarioService>();
            services.AddTransient<ConverterCargoCargoIdService>();
            services.AddTransient<ConverterGrauGrauIdService>();
            services.AddTransient<RetornaIdadeService>();
            services.AddTransient<IEditarCargoService, EditarCargoService>();
            services.AddTransient<EditarCargoRepository>();
            services.AddTransient<IEditarFuncionarioService, EditarFuncionarioService>();
            services.AddTransient<EditarFuncionarioRepository>();
            services.AddTransient<IBaterPontoService, BaterPontoService>();
            services.AddTransient<BaterPontoRepository>();
            services.AddTransient<ISalarioService, SalarioService>();
            services.AddTransient<SalarioRepository>();
            services.AddTransient<VerificarHorasTrabalhadasService>();
            services.AddTransient<TabelaSalarioRepository>();

        }
    }
}
