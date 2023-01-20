using Aplication.Product.Dto;
using Aplication.Product.Main;
using AutoMapper;
using Domain.Entities.Constant;
using Domain.Exception;
using Domain.Interface;
using Infrastructure.Common;

namespace Aplication.Product
{
    public class ProductService : IProductService
    {

        private readonly IGenericRepository<Domain.Entities.Entity.Product> _repository;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Domain.Entities.Entity.Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<Domain.Entities.Entity.Product>> Consult
            (int state = (int)ConstantsDomain.Stock)
        {
            try
            {
                var response = await _repository.GetAsync(x => x.State == state);
                return new Response<Domain.Entities.Entity.Product>(response);
            }
            catch (AppException e)
            {
                return new Response<Domain.Entities.Entity.Product>(e.Message);
            }
        }

        public async Task<Response<Domain.Entities.Entity.Product>> Incoming(ProductDto Dto)
        {
            try
            {
                var product = _mapper.Map<Domain.Entities.Entity.Product>(Dto);
                await _repository.AddAsync(product);
                return new Response<Domain.Entities.Entity.Product>(product);
            }
            catch (AppException e)
            {
                return new Response<Domain.Entities.Entity.Product>(e.Message);
            }
        }

        public async Task<Response<Domain.Entities.Entity.Product>> MarkFaulty(Guid id)
        {
            try
            {
                var find = await _repository.GetByIdAsync(id);

                find.MarkFaulty();

                if (find == null)
                {
                    return new Response<Domain.Entities.Entity.Product>("Error, Valide la informacion suministrada");
                }

                await _repository.UpdateAsync(find);

                return new Response<Domain.Entities.Entity.Product>("Producto actualizado con exito", false);
            }
            catch (AppException e)
            {
                return new Response<Domain.Entities.Entity.Product>(e.Message);
            }
        }

        public async Task<Response<Domain.Entities.Entity.Product>> MarkOutlet(Guid id)
        {
            try
            {
                var find = await _repository.GetByIdAsync(id);

                find.MarkOutlet();

                if (find == null)
                {
                    return new Response<Domain.Entities.Entity.Product>("Error, Valide la informacion suministrada");
                }

                await _repository.UpdateAsync(find);

                return new Response<Domain.Entities.Entity.Product>("Producto actualizado con exito", false);
            }
            catch (AppException e)
            {
                return new Response<Domain.Entities.Entity.Product>(e.Message);
            }
        }
    }
}
