using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class PagoE
    {
        public int IdPago { get; set; }
        public decimal Monto { get; set; }
        public string Comprobante { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public PersonaE personaE = new PersonaE();
        public MetaE metaE = new MetaE();
    }
}
