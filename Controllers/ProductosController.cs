using Microsoft.AspNetCore.Mvc;

namespace MiApiRender.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var productos = new[]
        {
            new { Id = 1, Nombre = "Laptop", Precio = 5000 },
            new { Id = 2, Nombre = "Mouse", Precio = 150 },
            new { Id = 3, Nombre = "Teclado", Precio = 300 }
        };

        return Ok(productos);
    }
}