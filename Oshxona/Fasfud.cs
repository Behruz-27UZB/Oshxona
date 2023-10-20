using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oshxona
{
    public class Fasfud
    {
        public string? Nomi { get; set; }
        public decimal Narxi { get; set; }
        public Fasfud
            (
                string? Nomi,
                decimal Narxi
            )
        {
            this.Nomi = Nomi;
            this.Narxi = Narxi;
        }
    }
}
