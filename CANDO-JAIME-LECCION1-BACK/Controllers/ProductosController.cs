using CANDO_JAIME_LECCION1_BACK.Models;
using Microsoft.AspNetCore.Mvc; // Usar este espacio de nombres para MVC

namespace CANDO_JAIME_LECCION1_BACK.Controllers
{
    [Route("api/producto")]
    [ApiController]
    public class ProductosController: ControllerBase
    {
        private ProductoContext _context;
        public ProductosController(ProductoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Producto> Get() => _context.Productos.ToList();
        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Productos.Add(producto);
                _context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("{codigo}")]
        public IActionResult Delete(string codigo)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }   
    }


}
