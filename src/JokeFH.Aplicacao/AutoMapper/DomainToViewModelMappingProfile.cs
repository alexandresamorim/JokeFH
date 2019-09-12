using AutoMapper;
using JokeFH.Aplicacao.ViewModels;
using JokeFH.Dominio.Entities;

namespace JokeFH.Aplicacao.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Historico, HistoricoViewModel>();
        }
    }
}
