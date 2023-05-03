using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbeMedic.Modelos
{
    public class PedidosFechas
    {
        public string F_Entrega { get; set; }
        public string H_Entrega { get; set; }
        public bool B_Parcial { get; set; }
        public string PacienteCartaPedido { get; set; }
        public string Atencion { get; set; }
        public string Carta_Pedido { get; set; }
        public string Carta { get; set; }
        public decimal Monto_Carta { get; set; }
        public string Siniestro_Pedido { get; set; }
        public string Siniestro { get; set; }
        public string Reclamacion_Pedido { get; set; }
        public string Poliza_Pedido { get; set; }
        public Int32 K_Celula_Pedido { get; set; }
        public Int32 K_Tipo_PagoCoaseguro { get; set; }
        public bool B_CoaCobReq { get; set; }
        public bool B_ConCoaseguro { get; set; }
        public decimal Coaseguro_Porcentaje_Pedido { get; set; }
        public decimal Coaseguro_Pedido { get; set; }
        public bool B_Programado { get; set; }
        public string Reclamacion { get; set; }

    }
}
