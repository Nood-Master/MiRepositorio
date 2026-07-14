using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using WebHelloWord.Dto;
using WebHelloWord.Parametros;

namespace WebHelloWord.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VectorController : ControllerBase
    {

        [HttpGet]
        [Route("[action]")]
        public IActionResult Get()
        {

            return Ok("HelloWord");
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult CalcularPromedio(List<Decimal> vector)
        {

            if (vector == null || vector.Count == 0)
                return Ok(0);

            var sum = vector.Sum(x => x);

            var promedio = sum / vector.Count;

            return Ok(promedio);
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult ContarPares(List<Decimal> vector)
        {
            Respuesta respuestaAuxiliar = new();
            Respuesta respuesta = respuestaAuxiliar;
            try
            {
                var listaPares = vector.Where(x => x % 2 == 0).ToList();
                respuesta.Success = true;
                respuesta.Valor = listaPares.Count;
            }
            catch (Exception ex)
            {
                respuesta.Success = false;
                respuesta.ErrorMessage = ex.Message;
            }
            return Ok(respuesta);

        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult ContarImpares(List<Decimal> vector)
        {
            Respuesta respuestaAuxiliar = new();
            Respuesta respuesta = respuestaAuxiliar;
            try
            {
                var listaImpares = vector.Where(x => x % 2 != 0).ToList();
                respuesta.Success = true;
                respuesta.Valor = listaImpares.Count;
            }
            catch (Exception ex)
            {
                respuesta.Success = false;
                respuesta.ErrorMessage = ex.Message;
            }
            return Ok(respuesta);

        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult FrecuenciaI(ParamFrecuencia param)
        {
            Respuesta respuesta = new Respuesta();

            int x = param.X;
            var vector = param.Vector;
            foreach (var item in vector)
            {
                Console.WriteLine(item);
            }



            return Ok(param);
        }
    }
}
