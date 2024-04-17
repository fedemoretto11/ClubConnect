using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Core.Entidades
{
    internal class Socios
    {

		private int dni { get; set; }
		private string nombre { get; set; }
		private string apellido { get; set; }
		private DateTime fechaDeNacimiento { get; set; }
		private string direccion { get; set; }
		private string email { get; set; }
		private string telefono { get; set; }
		private DateTime fechaDeRegistro { get; set; }
		private bool estaActivo { get; set; }

		//Contructores
		public Socios()
		{

		}

		public Socios(int dni, string nombre, string apellido, DateTime fechaDeNacimiento, string direccion, string email, string telefono)
		{
			this.dni = dni;
			this.nombre = nombre;
			this.apellido = apellido;
			this.fechaDeNacimiento = fechaDeNacimiento;
			this.direccion = direccion;
			this.email = email;
			this.telefono = telefono;
			fechaDeRegistro = DateTime.Now;
			this.estaActivo = true;

		}

		


	}
}
