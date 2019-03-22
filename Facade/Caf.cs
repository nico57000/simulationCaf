using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Caf
    {
        private BureauRecouvrement _Recouvrement;

        public BureauRecouvrement Recouvrement
        {
            get {
                if (_Recouvrement == null)
                {
                    _Recouvrement = new BureauRecouvrement();
                }
                return _Recouvrement;
            }
            //set { _Recouvrement = value; }
        }

        private BureauArchive _Archive;

        public BureauArchive Archive
        {
            get {
                if (_Archive == null)
                {
                    _Archive = new BureauArchive(new List<Dossier>());
                }
                return _Archive;
            }
            //set { _Archive = value; }
        }

        private BureauAllocationLoyer _AllocLoyer;

        public BureauAllocationLoyer AllocLoyer
        {
            get {
                if (_AllocLoyer == null)
                {
                    _AllocLoyer = new BureauAllocationLoyer();
                }
                return _AllocLoyer;
            }
            //set { _AllocLoyer = value; }
        }

        private BureauAllocationFamille _AllocFamille;

        public BureauAllocationFamille AllocFamille
        {
            get {
                if (_AllocFamille == null)
                {
                    _AllocFamille = new BureauAllocationFamille();
                }
                return _AllocFamille;
            }
            //set { _AllocFamille = value; }
        }

        private Compta _Compta;

        public Compta Compta
        {
            get {
                if (_Compta == null)
                {
                    _Compta = new Compta();
                }
                return _Compta;
            }
            //set { _Compta = value; }
        }

        public void TraiterApl(Dossier D)
        {
            Archive.ListDoss.Add(D);
            AllocLoyer.TestAllocLoyer(D);
            AllocFamille.TestAllocFam(D);
            Recouvrement.SetDette(D);
            Compta.payer(D);
            Console.WriteLine("-------------------------------------------");
        }

    }
}
