using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Core
{
	internal class Pagos
	{
		private int dni { get; set; }
		private string nombre { get; set; }
		private string apellido { get; set; }
		private DateTime fechaDeNacimiento { get; set; }
		private string direccion {  get; set; }
		private string email {  get; set; }
		private string telefono {  get; set; }
		private DateTime fechaDeRegistro { get; set; }
		private Boolean estaActivo { get; set; }
	}
}
