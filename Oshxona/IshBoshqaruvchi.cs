using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oshxona
{
    public class IshBoshqaruvchi
    {
        public void Kod(string? password)
        {
            string? password1 = "Behruz27";
            while (password != password1)
            {
                Console.Write("Parolni kirting: ");
                password = Console.ReadLine();
            }
        }
    }
}
