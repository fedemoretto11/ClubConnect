using ClubConnect.Api.Models;
using System.Diagnostics;
using ClubConnect.Api.Models.Entidades;
using ClubConnect.Api.Models.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace ClubConnect.Api.Controllers
{
	//[Route("api/[controller]")]
	//[ApiController]
	public class SocioController : Controller
	{
		private ISocioRepositorio _socioRepositorio;			
		

		public SocioController(ISocioRepositorio socioRepositorio) 
		{
			_socioRepositorio = socioRepositorio;
		}


        #region ApiComentado
        //[HttpGet]
        //public async Task<ActionResult<List<Socio>>> ObtenerTodosLosSociosAsync()
        //{
        //	try
        //	{
        //		var socios = await _socioRepositorio.ObtenerTodosLosSocios();
        //		return Ok(socios);
        //	}
        //	catch(Exception ex)
        //	{
        //		return StatusCode(500, "Internal Sever Error");
        //	}

        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Socio>> ObtenerSocioPorIdAsync(int id) 
        //{
        //	Socio socio = await _socioRepositorio.ObtenerSocioPorId(id);
        //	if (socio == null)
        //	{
        //		return NotFound("Socio no encontrado");
        //	}
        //	return Ok(socio);
        //}

        //[HttpPost]
        //public async Task<ActionResult<List<Socio>>> CrearSocioAsync(Socio socio)
        //{
        //	try
        //	{
        //		await _socioRepositorio.CrearSocioAsync(socio);
        //		return Ok(await ObtenerTodosLosSociosAsync());

        //	}
        //	catch (Exception ex)
        //	{
        //		return StatusCode(500, "Internal Server Error " + ex.Message);
        //	}
        //}

        //[HttpPut]
        //public async Task<ActionResult<Socio>> ActualizarSocioAsync(Socio socio)
        //{
        //	try
        //	{
        //		await _socioRepositorio.ActualizarSocioAsync(socio);
        //		return Ok(socio);
        //	}
        //	catch(Exception ex) 
        //	{
        //		return StatusCode(500, "Error de noseque " + ex.Message);
        //	}

        //}

        //[HttpPut]
        //public async Task<ActionResult<Socio>> DarDeBajaAltaSocioAsync(Socio socio)
        //{
        //	try
        //	{
        //		await _socioRepositorio.DarDeBajaAltaSocioAsync(socio);
        //		return Ok(socio);
        //	}
        //	catch (Exception ex)
        //	{
        //		return StatusCode(500, "Error de noseque " + ex.Message);
        //	}
        //}
        #endregion

        #region Modelo MVC

        public IActionResult Index()
        {
            return View();
        }

        public string Socio()
        {
            return "Aca irian los socios";
        }

        public string Prueba(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }







        #endregion


    }
}
