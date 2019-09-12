using AutoMapper;
using JokeFH.Aplicacao.ViewModels;
using JokeFH.Dominio.Entities;

namespace JokeFH.Aplicacao.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<HistoricoViewModel, Historico> ();
        }
    }
}
