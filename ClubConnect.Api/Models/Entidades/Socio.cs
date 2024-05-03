using static ClubConnect.Api.Models.Enum.Enum;

namespace ClubConnect.Api.Models.Entidades
{
	public class Socio
	{
		#region Propiedades publicas
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
		public EstaActivo EstaActivo
		{
			get { return estaActivo; }
			set { estaActivo = value; }
		}
		public DateTime FechaDeNacimiento
		{
			get { return fechaDeNacimiento; }
			set { fechaDeNacimiento = value; }
		}
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
