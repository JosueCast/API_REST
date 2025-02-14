using InventarioBackend.Models;

namespace InventarioBackend.Repository
{
    
        public interface IProductoDAO
        {
            Task<IEnumerable<Producto>> Get();
            Task<Producto> GetById(int id);
            Task Add(Producto entity);
            void Update(Producto entity);
            void Delete(Producto entity);
            Task Save();
        }

    
}
