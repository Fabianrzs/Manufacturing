using Aplication.Product.Dto;
using AutoMapper;

namespace Aplication.Product.Main
{
    public class ProductoProfile: Profile
    {
        public ProductoProfile()
        {
            CreateMap< Domain.Entities.Entity.Product, ProductDto>().ReverseMap();
        }
    }
}
