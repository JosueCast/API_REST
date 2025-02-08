using InventarioBackend.Data;
using InventarioBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventarioBackend.Controllers
{
    
        [Route("api/productos")]
        [ApiController]
        public class ProductosController : ControllerBase
        {
            private readonly ApplicationsDbContext _context;

            public ProductosController(ApplicationsDbContext context)
            {
                _context = context;
            }
            
            // GET: api/productos obtenemos los productos en una lista para mostrar
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
            {
                return await _context.Productos.ToListAsync();
            }

            // GET: api/productos/{id} obtenemos un producto por id 
            [HttpGet("{id}")]
            public async Task<ActionResult<Producto>> GetProducto(int id)
            {
                var producto = await _context.Productos.FindAsync(id);
                if (producto == null)
                    return NotFound();

                return producto;
            }

            // POST: api/productos guardamos un producto a nuestra base de datos
            [HttpPost]
            public async Task<ActionResult<Producto>> PostProducto(Producto producto)
            {
                _context.Productos.Add(producto);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
            }

            // PUT: api/productos/{id} actualizamos un producto a nuestra base de datos en sql server
            [HttpPut("{id}")]
            public async Task<IActionResult> PutProducto(int id, Producto producto)
            {
                if (id != producto.Id)
                    return BadRequest();

                _context.Entry(producto).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Productos.Any(e => e.Id == id))
                        return NotFound();

                    throw;
                }

                return NoContent();
            }

            // DELETE: api/productos/{id} eliminamos un producto en de nuestra tabla Productos de nuestra base de datos
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteProducto(int id)
            {
                var producto = await _context.Productos.FindAsync(id);
                if (producto == null)
                    return NotFound();

                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
    }