using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class BureauArchive
    {
        private List<Dossier> _ListDoss;

        public List<Dossier> ListDoss
        {
            get { return _ListDoss; }
            set { _ListDoss = value; }
        }

        public BureauArchive(List<Dossier> listDoss)
        {
            ListDoss = listDoss;
        }



    }
}