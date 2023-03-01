using Microsoft.AspNetCore.Mvc;
using WebApiCamaras.Entidades;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/camaras")]
    public class CamaraController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Camara>> Get() 
        {
            return new List<Camara>()
            {
                new Camara() {Cam_Id = 1, Costo= 300, Tipo_Id = 2, Color = "Negra", Marca_Id = 3, Proveedor_Id = 1},
                new Camara() {Cam_Id = 2, Costo= 500, Tipo_Id = 1, Color = "Blanca", Marca_Id = 1, Proveedor_Id = 2}
            };
        }
    }
}
