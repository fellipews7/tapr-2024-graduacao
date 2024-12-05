using AutoMapper;
using Domain.Entities;
using Domain.ViewModel;

namespace CrossCutting.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile() 
    {
        CreateMap<AlunoAvaliacaoViewModel, AlunoAvaliacao>();
        CreateMap<AlunoPresencaViewModel, AlunoPresenca>();
        CreateMap<AlunoTurmaViewModel, AlunoTurma>();
        CreateMap<AulaViewModel, Aula>();
        CreateMap<AvaliacaoViewModel, Avaliacao>();
        CreateMap<CursoViewModel, Curso>();
        CreateMap<DisciplinaViewModel, Disciplina>();
        CreateMap<SalaViewModel, Sala>();
        CreateMap<TurmaViewModel, Turma>();
    }
}
