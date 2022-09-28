using api_autores.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_autores.Controllers
{
    //dinciamos que es un controlador
    [ApiController]
    //es definir la ruta de acceso al controlador
    [Route("api-autores/autor")]
    //: ControllerBase es una herencia para que sea un controlador
    public class AutorController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        //creamos el método constructor
        public AutorController(ApplicationDBContext context)
        {
            this.context = context;
        }


        //cuando queremos obtener informacion
        [HttpGet]
        public async Task<ActionResult<List<Autor>>> findAll()
        {
            return await context.Autor.ToListAsync();
        }

        //cuando queremos guardar información
        [HttpPost]
        public async Task<ActionResult> add(Autor a)
        {
            context.Add(a);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
