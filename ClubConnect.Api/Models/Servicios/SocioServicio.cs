using ClubConnect.Api.Models.Entidades;
using static ClubConnect.Api.Models.Enum.Enum;

namespace ClubConnect.Api.Models.Servicios
{
	public class SocioServicio
	{
		public SocioServicio()
		{
			// Aquí podrías realizar inicializaciones si es necesario
		}

		public Socio CrearSocio(int dni, string nombre, string apellido, string direccion, string telefono, string email, CategoriaSocio categoria, DateTime fechaDeNacimiento)
		{
			try
			{
				if (dni == int.MinValue || dni == 0) throw new ArgumentException("DNI faltante");

				Socio socio = new Socio();
				socio.Dni = dni;
				socio.Nombre = nombre ?? throw new ArgumentNullException("Falta el nombre");
				socio.Apellido = apellido ?? throw new ArgumentNullException("Falta el apellido");
				socio.Direccion = direccion;
				socio.Telefono = telefono ?? throw new ArgumentNullException("Falta el telefono");
				socio.Email = email;
				socio.Categoria = categoria;
				socio.FechaDeNacimiento = fechaDeNacimiento;
				socio.FechaDeRegistro = DateTime.Now;
				socio.EstaActivo = EstaActivo.SI;

				return socio;

			}
			catch (Exception ex) 
			{
				Console.WriteLine($"Error: {ex.Message}");
				return null;
			}
		}
	}
}
