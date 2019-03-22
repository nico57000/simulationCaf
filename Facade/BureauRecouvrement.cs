using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class BureauRecouvrement : Random
    {
        private static BureauRecouvrement _Instance;

        public static BureauRecouvrement Instance
        {
            get {
                if (_Instance == null)
                {
                    _Instance = new BureauRecouvrement();
                }
                return _Instance;
            }
        }

        public void SetDette(Dossier D)
        {
            if (Instance.Next(0,5) < 2)
            {
                D.Dette -= Instance.Next(1, 100);
            }
            else if (Instance.Next(0,5) >= 2)
            {
                D.Dette += Instance.Next(1, 100);
            }
        }

        

    }
}
