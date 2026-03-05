using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCRUD_api.Features.Abonados;
using WebCRUD_api.enitities;

namespace WebCRUD_api.Controllers
{
    [Route("api/Abonadoscontroller")]
    [ApiController]
    public class AbonadosController : ControllerBase
    {
        private readonly AbonadosAppService appService;

        public AbonadosController(AbonadosAppService appService) 
        {
            this.appService = appService;
        }

        [HttpGet("ObtenerAbonados")]
        public IActionResult ObtenerAbonados()
        {
            List<Abonado> abonados = appService.ObtenerAbonados();
            return Ok(abonados);
        }
        [HttpGet]
        [Route("ObtenerAbonadoPorId/{id}")]
        public IActionResult ObtenerAbonadoPorId([FromRoute]int id)
        {
           
            return Ok(appService.ObtenerAbonadoPorId(id));
        }
        [HttpPost]
        [Route("GuardarAbonado")]
        public IActionResult GuardarAbonado([FromBody] Abonado abonado)
        {
            appService.GuardarAbonado(abonado);
            return Ok();
        }

           [HttpPut]
           [Route("ActualizarAbonado")]
              public IActionResult ActualizarAbonado([FromBody] Abonado abonado)
              {
                appService.ActualizarAbonado(abonado);
                return Ok();
              }
        [HttpDelete]
        [Route("EliminarAbonado/{id}")]
        public IActionResult EliminarAbonado([FromRoute] int id)
        {
            appService.EliminarAbonado(id);
            return Ok();
        }
    }
}
