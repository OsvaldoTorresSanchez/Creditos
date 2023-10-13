using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Credito
    {


        public int NumeroCredito { get; set; }


        public decimal ImporteCredito { get; set; }

        public int PLazo { get; set; }

        public decimal TasaAnual { get; set; }

        public List<object> Creditos { get; set; }

    }
}
