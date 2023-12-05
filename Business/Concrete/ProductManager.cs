using Business.Abstract;
using Core.DataAccess.Paging;
using Core.DataAccess;
using Entities.Concretes;
using Octopus.Client.Repositories.Async;
using DataAccess.Abstracts;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public async Task Add(Product product)
        {
            await _productDal.AddAsync(product);
        }

        public async Task<Paginate<Product>> GetListAsync()
        {
            var result = await _productDal.GetListAsync();
            return result;
        }
    }
}
