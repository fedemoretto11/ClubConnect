using System.ComponentModel.DataAnnotations;
using static ClubConnect.Api.Models.Enum.PagosEnum;

namespace ClubConnect.Api.Models.Entidades
{
    public class Pagos
    {
        #region Propiedades privadas
        private int id { get; set; }
        private int idSocio { get; set; }


        // Ver como combiene guardar el mes que se debe abonar
        private int anio { get; set; }
        private int mes { get; set; }
        //private DateOnly fechaDeuda { get; set; }
        
        
        private EstadoDeuda estadoDeuda { get; set; }
        private string medioDePago {  get; set; }
        private int numeroPago{  get; set; }
        private DateOnly fechaPago { get; set; }

        #endregion

        #region Propiedades publicas

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Display(Name = "N° Socio")]
        public int IdSocio
        {
            get { return idSocio; }
            set { idSocio = value; }
        }

        [Display(Name  = "Año")]
        public int Anio
        {
            get { return anio;  }
            set { anio = value; }
        }

        public int Mes
        {
            get { return mes;  }
            set { mes = value; }
        }

        public EstadoDeuda EstadoDeuda
        {
            get { return estadoDeuda; }
            set { estadoDeuda = value; }
        }
        #endregion

    }
}
