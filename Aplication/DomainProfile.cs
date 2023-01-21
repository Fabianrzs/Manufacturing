using Aplication.Product.Dto;
using AutoMapper;

namespace Aplication
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Domain.Entities.Entity.Product, ProductDto>().ReverseMap();
        }
    }
}
