using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Core.Entidades
{
    public class Socios
    {

		public int dni { get; set; }
		public string nombre { get; set; }
		public string apellido { get; set; }
		public DateTime fechaDeNacimiento { get; set; }
		public string direccion { get; set; }
		public string email { get; set; }
		public string telefono { get; set; }
		public DateTime fechaDeRegistro { get; set; }
		public bool estaActivo { get; set; }

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
