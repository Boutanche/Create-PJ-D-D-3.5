using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.Version03
{
    class Personnages
    {
       
        
        public void PersonnageJoueur()
        {
            Generateur nouveauPersonnage = new Generateur();
            nouveauPersonnage.Generation();
            Console.WriteLine("Test : "+ nouveauPersonnage.Generation());
            

        }
        
        



    }
}
