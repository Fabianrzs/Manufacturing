using Aplication.Product.Dto;
using Domain.Entities.Constant;
using Infrastructure.Common;

namespace Aplication.Product.Main
{
    public interface IProductService
    {
        Task<Response<Domain.Entities.Entity.Product>> Incoming(ProductDto Dto); //Ingreso de un producto
        Task<Response<Domain.Entities.Entity.Product>> Consult(int state); //Consultar Productos
        Task<Response<Domain.Entities.Entity.Product>> MarkFaulty(Guid id); //Cambiar estado de los productos 
        Task<Response<Domain.Entities.Entity.Product>> MarkOutlet(Guid id); //Cambiar estado de los productos 

    }
}
