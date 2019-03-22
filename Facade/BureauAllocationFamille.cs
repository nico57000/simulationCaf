using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class BureauAllocationFamille
    {
        public void TestAllocFam(Dossier D)
        {
            if (D.NbEnfant > 0)
            {
                D.ElligibleFamille = true;
                D.Dette += 85 * D.NbEnfant;
                Console.WriteLine("Monsieur "+D.Nom+" vous etes elligible à l'allocation familiale");
            }
            else
            {
                Console.WriteLine("Monsieur "+D.Nom+" vous netes pas elligible à l'allocation familiale");
            }
        }
    }
}
