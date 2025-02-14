using InventarioBackend.Data;
using InventarioBackend.Models;
using InventarioBackend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventarioBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly productoDAO _dao;

        public ProductoController(ApplicationsDbContext context)
        {
            _dao = new productoDAO(context);
        }

        [HttpGet("LeerProductos")]
        public async Task<ActionResult<List<Producto>>> ObtenerListado()
        {
            var productos = await _dao.Get();

            // Verificar si la lista está vacía o es nula
            if (productos == null || !productos.Any())
            {
                return NotFound("No se encontraron productos.");
            }
            return Ok(productos);
        }


        [HttpGet("ObtenerPorId/{id}")]
        public async Task<ActionResult<Producto>> ObtenerPorId(int id)
        {
            var producto = await _dao.GetById(id);

            if (producto == null)
            {
                return NotFound($"No se encontró el producto con ID {id}");
            }

            return Ok(producto);
        }

        [HttpDelete("EliminarProducto/{id}")]
        public async Task<ActionResult> EliminarProducto(int id)
        {
            try
            {
                var producto = await _dao.GetById(id);
                if (producto == null)
                {
                    return NotFound("Producto no encontrado.");
                }

                _dao.Delete(producto);
                await _dao.Save();

                return Ok(new { mensaje = "Producto eliminado con éxito" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error interno del servidor", error = ex.Message });
            }
        }

        [HttpPost("InsertarProducto")]
        public async Task<ActionResult> InsertarProducto([FromBody] Producto productoDTO)
        {
            if (productoDTO == null || string.IsNullOrWhiteSpace(productoDTO.Nombre) || productoDTO.Stock < 0 || productoDTO.Precio <= 0)
            {
                return BadRequest("Datos de producto inválidos.");
            }

            var nuevoProducto = new Producto
            {
                Nombre = productoDTO.Nombre,
                Stock = productoDTO.Stock,
                Precio = productoDTO.Precio
            };

            await _dao.Add(nuevoProducto);
            await _dao.Save();

            return CreatedAtAction(nameof(ObtenerPorId), new { id = nuevoProducto.Id }, nuevoProducto);
        }

        [HttpPut("EditarProducto/{id}")]
        public async Task<ActionResult> ActualizarProducto(int id, [FromBody] Producto producto)
        {
            if (producto == null || string.IsNullOrWhiteSpace(producto.Nombre) || producto.Stock < 0 || producto.Precio <= 0)
            {
                return BadRequest("Datos de producto inválidos.");
            }

            // Obtener el producto desde la base de datos
            var productoExistente = await _dao.GetById(id);
            if (productoExistente == null)
            {
                return NotFound("Producto no encontrado.");
            }

            // Actualizar los datos del producto existente
            productoExistente.Nombre = producto.Nombre;
            productoExistente.Stock = producto.Stock;
            productoExistente.Precio = producto.Precio;

            // Realizar la actualización
            _dao.Update(productoExistente);
            await _dao.Save();

            return Ok(productoExistente);  // Retornar el producto actualizado
        }
    }
}
