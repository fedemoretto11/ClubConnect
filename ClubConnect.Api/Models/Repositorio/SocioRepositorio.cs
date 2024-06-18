using System.Net;
using ClubConnect.Api.Models.Data;
using ClubConnect.Api.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static ClubConnect.Api.Models.Enum.Enum;

namespace ClubConnect.Api.Models.Repositorio
{
	public class SocioRepositorio : ISocioRepositorio
	{
		protected readonly DataContext _db;
		public SocioRepositorio(DataContext db)
		{
			_db = db;
		}

		public async Task<Socio> ActualizarSocioAsync(Socio socioActualizado)
		{
			
			var socioDB = await ObtenerSocioPorId(socioActualizado.Id);
			if (socioDB == null) return null;

			socioDB.Dni = socioActualizado.Dni;
			socioDB.Nombre = socioActualizado.Nombre;
			socioDB.Apellido = socioActualizado.Apellido;
			socioDB.Direccion = socioActualizado.Direccion;
			socioDB.Telefono = socioActualizado.Telefono;
			socioDB.Email = socioActualizado.Email;
			socioDB.Categoria = socioActualizado.Categoria;
			socioDB.EstaActivo = socioActualizado.EstaActivo;
			socioDB.FechaDeNacimiento = socioActualizado.FechaDeNacimiento;

			await _db.SaveChangesAsync();
			return socioActualizado;
		}

		public async Task<List<Socio>> CrearSocioAsync(Socio socio)
		{
			await _db.Socios.AddAsync(socio);
			await _db.SaveChangesAsync();
			return await ObtenerTodosLosSocios();
		}

		public async Task<Socio> DarDeBajaAltaSocioAsync(Socio socio)
		{
			var socioDB = await ObtenerSocioPorId(socio.Id);
			if (socio == null) return null;
			if (socio.EstaActivo == EstaActivo.SI)
			{
				socioDB.EstaActivo = EstaActivo.NO;
			}
			else
			{
				socioDB.EstaActivo = EstaActivo.SI;
			}
			await _db.SaveChangesAsync();
			return socio;
		}


		public async Task<Socio> ObtenerSocioPorId(int id)
		{
			var socio = await _db.Socios.FindAsync(id);
			if (socio == null) return null;
			return socio;
		}

		public async Task<List<Socio>> ObtenerTodosLosSocios()
		{
			return await _db.Socios.ToListAsync();
		}
	}
}
