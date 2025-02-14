using InventarioBackend.Data;
using InventarioBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioBackend.Repository
{
    public class productoDAO : IProductoDAO
    {
        private readonly ApplicationsDbContext _context;

        public productoDAO(ApplicationsDbContext storeContext)
        {
            _context = storeContext;
        }

        public async Task<IEnumerable<Producto>> Get() => await _context.Productos.ToListAsync();

        public async Task<Producto> GetById(int id) => await _context.Productos.FindAsync(id);

        public async Task Add(Producto entity) => await _context.Productos.AddAsync(entity);

        public void Update(Producto entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Producto entity) => _context.Productos.Remove(entity);

        public async Task Save() => await _context.SaveChangesAsync();
    }

}
