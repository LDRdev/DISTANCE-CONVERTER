using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Km_e_milhas
{
    class Conversor
    {
        public float valor { get; set; }

        public float converteKm()
        {
            return valor / 1.60934f;

        }

        public float converteMilhas()
        {
            return valor * 1.60934f;
        }
    }
}
