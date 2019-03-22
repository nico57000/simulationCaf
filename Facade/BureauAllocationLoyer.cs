using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class BureauAllocationLoyer
    {

        public void TestAllocLoyer(Dossier D)
        {
            if (D.Salaire < 2 * D.Loyer)
            {
                D.ElligibleLogement = true;
                D.Dette += 150;
                Console.WriteLine("Monsieur "+D.Nom+" vous etes elligible à l'allocation logement");
            }
            else
            {
                Console.WriteLine("Monsieur "+D.Nom+" vous n'etes pas elligible à l'allocation logement");
            }
        }
    }
}
