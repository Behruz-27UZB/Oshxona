using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oshxona
{
    public class Mijoz
    {
        public Mijoz()
        {

        }
        public Mijoz
        (
         string Ismi,
         int Yoshi,
         long TelifonRaqami,
         string X_T_Nomi,
         decimal X_T_Narxi
        )
        {
            this.Ismi = Ismi;
            this.TelifonRaqami = TelifonRaqami;
            this.Yoshi = Yoshi;
            this.X_T_Nomi = X_T_Nomi;
            this.X_T_Narxi = X_T_Narxi;

        }
        public string? Ismi { get; set; }
        public int Yoshi { get; set; }
        public long TelifonRaqami { get; set; }
        public string? X_T_Nomi { get; set; }
        public decimal X_T_Narxi { get; set; }
    }
}
