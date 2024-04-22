using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClubConnect.Core.Entidades;
using Dapper;
using MySql.Data.MySqlClient;

namespace ClubConnect.Data.Repositorios
{
	public class SociosRepositorio : ISociosRepositorio
	{
		private readonly MySQLConfiguracion _connectionString;

		public SociosRepositorio(MySQLConfiguracion connectionString)
		{
			_connectionString = connectionString;
		}

		protected MySqlConnection dbConexion()
		{
			return new MySqlConnection(_connectionString.ConnectionString);
		}

		public Task<bool> ActualizarSocio(Socios socio)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> AgregarSocio(Socios socio)
		{
			var db = dbConexion();

			var sqlString = @"INSERT INTO socios(DNI, NOMBRE, APELLIDO, FECHA_DE_NACIMIENTO, DIRECCION, EMAIL, TELEFONO, FECHA_REGISTRO, ESTA_ACTIVO) VALUES (@dni, @nombre, @apellido, @fechaDeNacimiento, @direccion, @email, @telefono, @fechaDeRegistro, @estaActivo)";

			var result = await db.ExecuteAsync(sqlString, new
			{
				socio.dni,
				socio.nombre,
				socio.apellido,
				socio.fechaDeNacimiento, 
				socio.direccion,
				socio.email,
				socio.telefono,
				socio.fechaDeRegistro,
				socio.estaActivo,
			});
			return result > 0;
		}

		public async Task<bool> DarDeAltaBajaSocio(int dni)
		{
			var db = dbConexion();
			string sqlString;

			Socios socio = await ObtenerUnSocio(dni);

			if (socio.estaActivo == 0)
			{
				sqlString = @"UPDATE socios SET esta_activo = 1 WHERE DNI = @Dni";
			}
			else
			{
				sqlString = @"UPDATE socios SET esta_activo = 0 WHERE DNI = @Dni";
			}

			var result = await db.ExecuteAsync(sqlString, new { dni });
			return result > 0;

		}

		public async Task<IEnumerable<Socios>> ObtenerTodosLosSocios()
		{
			var db = dbConexion();

			var sqlString = @"SELECT * FROM socios";

			return await db.QueryAsync<Socios>(sqlString, new { });
		}

		public async Task<Socios> ObtenerUnSocio(int dni)
		{
			var db = dbConexion();

			var sqlString = @"SELECT * FROM socios WHERE DNI = @dni";

			return await db.QueryFirstOrDefaultAsync<Socios>(sqlString, new { dni });
		}
	}
}
