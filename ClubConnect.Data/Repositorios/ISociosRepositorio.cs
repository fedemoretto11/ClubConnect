using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubConnect.Core.Entidades;

namespace ClubConnect.Data.Repositorios
{
	public interface ISociosRepositorio
	{
		Task<IEnumerable<Socios>> ObtenerTodosLosSocios();
		Task<Socios> ObtenerUnSocio(int dni);
		Task<bool> AgregarSocio(Socios socio);
		Task<bool> ActualizarSocio(Socios socio);
		Task<bool> DarDeAltaBajaSocio(Socios socio);
	}
}
