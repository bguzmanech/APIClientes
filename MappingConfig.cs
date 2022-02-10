using APIClientes.Modelos;
using APIClientes.Modelos.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIClientes
{
    public class MappingConfig /*mapeo entre Dto y Modelos*/
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ClienteDto, Cliente>();
                config.CreateMap<Cliente, ClienteDto>();
                config.CreateMap<User, UserDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
