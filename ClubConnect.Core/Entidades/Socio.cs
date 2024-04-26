using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Core.Entidades
{
	[Serializable]
	public class Socio
	{

		#region Propiedades Privadas
		[Key]
		public int id = 0;

		private int dni = int.MinValue;

		private string nombre = string.Empty;

		private string apellido = string.Empty;

		private DateTime fechaDeNacimiento = DateTime.MinValue;

		private string direccion = string.Empty;

		private string email = string.Empty;

		private string telefono = string.Empty;

		private DateTime fechaDeRegistro = DateTime.MinValue;

		private bool estaActivo = false;

		#endregion

		public Socio() {
			this.fechaDeRegistro = DateTime.Today.Date;
			this.estaActivo = true;
		}

		#region Propiedades Publicas
		public int Dni
		{
			get { return this.dni; }
			set { this.dni = value; }
		}

		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}

		public string Apellido
		{
			get { return this.apellido; }
			set { this.apellido = value; }
		}

		public DateTime FechaDeNacimiento
		{
			get { return this.fechaDeNacimiento; }
			set { this.fechaDeNacimiento = value; }
		}

		public string Direccion
		{
			get { return this.direccion; }
			set { this.direccion = value; }
		}

		public string Email
		{
			get { return this.email; }
			set { this.email = value; }
		}

		public string Telefono
		{
			get { return this.telefono; }
			set { this.telefono = value; }
		}

		public DateTime FechaDeRegistro
		{
			get { return this.fechaDeRegistro; }
		}

		public bool EstaActivo
		{
			get { return this.estaActivo; }
		}


		#endregion

		#region Metodos
		public void DarDeBaja()
		{
			this.estaActivo = false;
		}

		public void DarDeAlta()
		{
			this.estaActivo = true;
		}
		#endregion

	}
}
