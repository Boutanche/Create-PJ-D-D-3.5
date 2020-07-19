using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.Version03
{
    class Lanceur
    {
                    
        public int ResultatDuLancé;

        public int Lanceur1D6()
        {
            Random LeDé6 = new Random();
            Thread.Sleep(25);
            int resultatDé = LeDé6.Next(1, 7);
            ResultatDuLancé = resultatDé;
            return resultatDé;
            
        }

        public int Lanceur1D20()
        {
            Random LeDé20 = new Random();
            Thread.Sleep(25);
            int resultatDé = LeDé20.Next(1, 21);
            ResultatDuLancé = resultatDé;
            return resultatDé;
        }
    }
}
