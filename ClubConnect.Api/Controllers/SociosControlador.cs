using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClubConnect.Data.Repositorios;
using ClubConnect.Core.Entidades;


namespace ClubConnect.Api.Controllers
{
	[Route("/api/[controller]")]
	[ApiController]
	public class SociosControlador : ControllerBase
	{
		private readonly SociosRepositorio _sociosRepositorio;

		public SociosControlador(SociosRepositorio sociosRepositorio)
		{
			_sociosRepositorio = sociosRepositorio;
		}

		[HttpGet]
		public async Task<IActionResult> ObtenerTodosLosSocios()
		{
			return Ok(await _sociosRepositorio.ObtenerTodosLosSocios());
		}

		[HttpPost]
		public async Task<IActionResult> AgregarSocio([FromBody] Socios socio)
		{
			if (socio == null)
			{
				return BadRequest();
			}
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}

			var created = _sociosRepositorio.AgregarSocio(socio);

			return Created("created", created);
		}
	}
}
