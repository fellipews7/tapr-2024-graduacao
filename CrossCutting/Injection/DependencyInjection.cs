using Application.Interface;
using Application.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CrossCutting.Injection
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            #region Service
            services.TryAddScoped<IAlunoAvaliacaoService, AlunoAvaliacaoService>();
            services.TryAddScoped<IAlunoPresencaService, AlunoPresencaService>();
            services.TryAddScoped<IAlunoTurmaService, AlunoTurmaService>();
            services.TryAddScoped<IAulaService, AulaService>();
            services.TryAddScoped<IAvaliacaoService, AvaliacaoService>();
            services.TryAddScoped<ICursoService, CursoService>();
            services.TryAddScoped<IDisciplinaService, DisciplinaService>();
            services.TryAddScoped<ISalaService, SalaService>();
            services.TryAddScoped<ITurmaService, TurmaService>();

            #endregion
        }
    }
}
