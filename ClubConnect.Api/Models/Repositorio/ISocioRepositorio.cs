using ClubConnect.Api.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ClubConnect.Api.Models.Repositorio
{
	public interface ISocioRepositorio
	{
		Task<List<Socio>> CrearSocioAsync(Socio socio);
		Task<Socio> DarDeBajaAltaSocioAsync(Socio socio);
		Task<Socio> ObtenerSocioPorId(int id);
		Task<List<Socio>> ObtenerTodosLosSocios();
		Task<Socio> ActualizarSocioAsync(Socio socio);
	}
}
