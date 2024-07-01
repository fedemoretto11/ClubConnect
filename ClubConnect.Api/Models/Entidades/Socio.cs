using System.ComponentModel.DataAnnotations;
using static ClubConnect.Api.Models.Enum.SociosEnum;

namespace ClubConnect.Api.Models.Entidades
{
	public class Socio
	{
		#region Propiedades privadas
		private int id { get; set; }
		private int dni { get; set; }
		private string nombre { get; set; }
		private string apellido { get; set; }
		private string direccion { get; set; }
		private string telefono { get; set; }
		private string email { get; set; }
		private CategoriaSocio categoria { get; set; }
		private EstaActivo estaActivo { get; set; }
		private DateTime fechaDeNacimiento { get; set; }
		private DateTime fechaDeRegistro { get; set; }

        #endregion

        #region Propiedades publicas

        [Display(Name = "N° Socio")]
        public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}
		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}
		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		public CategoriaSocio Categoria
		{
			get { return categoria; }
			set { categoria = value; }
		}
        [Display(Name = "Esta Activo")]
        public EstaActivo EstaActivo
		{
			get { return estaActivo; }
			set { estaActivo = value; }
		}
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaDeNacimiento
		{
			get { return fechaDeNacimiento; }
			set { fechaDeNacimiento = value; }
		}
        [Display(Name = "Fecha de Registro")]
        [DataType(DataType.Date)]
        public DateTime FechaDeRegistro
		{
			get { return fechaDeRegistro; }
			set { fechaDeRegistro = value; }
		}

		#endregion

		#region Constructor

		public Socio(){}

		#endregion
	}
}
