using AutoMapper;
using RegistraPessoa.Api.Data.ValueObjects;
using RegistraPessoa.Api.Model.Base.PessoaBase;

namespace RegistraPessoa.Api.Mapping
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>{ 
            config.CreateMap<PessoaVO,Pessoa>().ReverseMap();
            config.CreateMap<PessoaVOtotal,Pessoa>().ReverseMap();
        });
            return mappingConfig;
        }    
    }
}