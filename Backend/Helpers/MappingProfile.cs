using AutoMapper;
using PessoasDesaparecidas.DTOs;
using PessoasDesaparecidas.Models;
using WebApplication1.Models;

namespace PessoasDesaparecidas.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pessoa, PessoaDTO>().ReverseMap();
            CreateMap<Desaparecimento, DesaparecimentoDTO>().ReverseMap();
        }
    }
}
