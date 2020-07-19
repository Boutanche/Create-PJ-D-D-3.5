using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.Version03
{
    class Terminal
    {
        public void Terminalfx(string pString)
        {
            Random random = new Random();
            Console.WriteLine("");
            foreach (char caractere in pString)
            {
                Console.Write("\b");
                Console.Write(caractere);
                Console.Write("#");
                Thread.Sleep(random.Next(10, 50));
            }
            Console.Write("\b ");
            Console.WriteLine("");
        }
    }
}
