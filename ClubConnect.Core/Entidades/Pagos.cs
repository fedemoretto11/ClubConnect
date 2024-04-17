using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubConnect.Core.Entidades
{
    internal class Pagos
    {
        private int id {  get; set; }
        private int dniSocio { get; set; }
        private DateTime fechaPago { get; set; }
        private string mesPago { get; set; }
        private string duracionPago { get; set; }
        private int? anioPago { get; set; }
        private decimal monto { get; set; }
        private string metodoPago { get; set; }
        private string estadoPago { get; set; }
        private string tipoPago { get; set; }
        private string detalles {  get; set; }

        public Pagos()
        {

        }

        public Pagos(int id, int dniSocio, DateTime fechaPago, string mesPago, string duracionPago, int? anioPago, decimal monto, string metodoPago, string estadoPago, string tipoPago, string detalles)
        {
            this.id = id;
            this.dniSocio = dniSocio;
            this.fechaPago = fechaPago;
            this.mesPago = mesPago;
            this.duracionPago = duracionPago;
            this.anioPago = anioPago;
            this.monto = monto;
            this.metodoPago = metodoPago;
            this.estadoPago = estadoPago;
            this.tipoPago = tipoPago;
            this.detalles = detalles;
        }
    }
}
