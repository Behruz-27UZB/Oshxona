using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oshxona
{
    public class OshxonaMalumotlari
    {
        public string[] fasfudNomi = { "Lavash", "Hoddok", "Pedsa" };

        public decimal[] fasfudNarxi = { 30000, 15000, 60000, };
        public bool TekshirFasfudNomini(string? fasfud_nomi)
        {
            foreach (var item in fasfudNomi)
            {
                if (fasfud_nomi == item)
                {
                    return true;
                }
            }
            return false;

        }
        public bool TekshirFasfudNarxini(decimal fasfud_narxi)
        {
            foreach (var item in fasfudNarxi)
            {
                if (fasfud_narxi == item)
                {
                    return true;
                }
            }
            return false;

        }
        public void BarchaMalumotlarniOlish()
        {
            int s = 0;
            for (int i = 0, j = 0; i < fasfudNomi.Length; i++, j++)
            {
                s++;
                Console.WriteLine(s + ")");
                Console.WriteLine(" " + fasfudNomi[i]);
                Console.WriteLine(" " + fasfudNarxi[j]);

            }


        }
        public void BittaMalumotniOlish(string? fasfud_Nomi)
        {
            bool res = false;
            for (int i = 0; i < fasfudNomi.Length; i++)
            {
                if (fasfudNomi[i] == fasfud_Nomi)
                {
                    res = true;
                    Console.WriteLine(fasfudNomi[i]);
                    Console.WriteLine(fasfudNarxi[i]);
                }

            }
            if (res == false)
            {
                    Console.WriteLine("Bunday fasfud yuq....");
            }


        }
        public void BittaFasfudniUchir(string? fasfud_Nomi)
        {
            bool natija = TekshirFasfudNomini(fasfud_Nomi);
            if (natija == true)
            {
                int i = Array.IndexOf(fasfudNomi, fasfud_Nomi);
                fasfudNomi[i] = "";
                fasfudNarxi[i] = 0;
            }
            else
            {
                Console.WriteLine("Bunday fasfud topilmadi... ");
            }
        }
        public void BarchaFasfudniUchir()
        {
            Array.Clear(fasfudNomi);
            Array.Clear(fasfudNarxi);

        }
        public void FasfudniQushish(string? fasfud_Nomi, decimal fasfud_Narxi)
        {
            bool natija = TekshirFasfudNomini(fasfud_Nomi);
            Array.Resize(ref fasfudNarxi, fasfudNarxi.Length + 1);
            fasfudNarxi[fasfudNarxi.Length - 1] = fasfud_Narxi;
            if (natija == false)
            {
                string.Join(fasfud_Nomi, fasfudNomi);
            }
            else
            {
                Console.WriteLine("Bu malumot mavjud");
            }
        }
    }

}
