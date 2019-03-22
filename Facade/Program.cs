using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Caf CafMoselle = new Caf();

            Dossier Cassos1 = new Dossier("Fillou", "Romain", 0, 1200, 800);
            Dossier Cassos2 = new Dossier("Yann", "Michaux", 2, 800, 500);
            Dossier Cassos3 = new Dossier("Macron", "Manu", 1, 30000, 0);
            Dossier Cassos4 = new Dossier("Trump", "Donald", 0, 120000, 1500);


            CafMoselle.TraiterApl(Cassos1);
            CafMoselle.TraiterApl(Cassos2);
            CafMoselle.TraiterApl(Cassos3);
            CafMoselle.TraiterApl(Cassos4);



        }
    }
}
