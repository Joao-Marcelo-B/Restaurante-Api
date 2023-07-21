using AutoMapper;
using RestauranteApi.Data.Dtos;
using RestauranteApi.Models;

namespace RestauranteApi.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>();
            CreateMap<UpdateClienteDto, Cliente>();
            CreateMap<Cliente, UpdateClienteDto>();
        }
    }
}
