using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Compta
    {
        public void VerifDette(Dossier D)
        {
            if (D.Dette > 0)
            {
                Console.WriteLine("Le locataire "+D.Nom+" doit payer "+D.Dette+" euros");
            }
            else if (D.Dette < 0)
            {
                Console.WriteLine("Le caf doit payer " + D.Dette + " euros au locataire "+D.Nom);
            }
        }

        public void VerifierAllocFamille(Dossier D)
        {
            if (D.ElligibleFamille == true)
            {
                Console.WriteLine("Payer l'allocation familliale");
            }
        }

        public void VerifierAllocLogement(Dossier D)
        {
            if (D.ElligibleLogement == true)
            {
                Console.WriteLine("Payer l'allocation logement");
            }
        }

        public void payer(Dossier D)
        {
            if (D.Dette > 0 )
            {
                Console.WriteLine("La caf vous verse la somme de "+D.Dette+" lingots d'or");
            }
            else if (D.Dette < 0)
            {
                Console.WriteLine("Vous devez la somme de "+D.Dette+" lingots d'or à la caf");
            }
            else
            {
                Console.WriteLine("Vos comptes sont à jour");
            }
        }

    }
}
