using System;
using System.Collections.Generic;
using System.Linq;
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

		public Task<bool> DarDeAltaBajaSocio(Socios socio)
		{
			throw new NotImplementedException();
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

			var sqlString = @"SELECT * FROM socios WHERE dni = @Dni";

			return await db.QueryFirstOrDefaultAsync<Socios>(sqlString, new { Dni = dni });
		}
	}
}
