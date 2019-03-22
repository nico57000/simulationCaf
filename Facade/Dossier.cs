using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Dossier
    {
        private string _Nom;

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        private string _Prenom;

        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }

        private int _NbEnfant;

        public int NbEnfant
        {
            get { return _NbEnfant; }
            set { _NbEnfant = value; }
        }

        private int _Salaire;

        public int Salaire
        {
            get { return _Salaire; }
            set { _Salaire = value; }
        }

        private int _Loyer;

        public int Loyer
        {
            get { return _Loyer; }
            set { _Loyer = value; }
        }

        private int _Dette;

        public int Dette
        {
            get { return _Dette; }
            set { _Dette = value; }
        }

        private bool _ElligibleFamille;

        public bool ElligibleFamille
        {
            get { return _ElligibleFamille; }
            set { _ElligibleFamille = value; }
        }

        private bool _ElligibleLOgement;

        public bool ElligibleLogement
        {
            get { return _ElligibleLOgement; }
            set { _ElligibleLOgement = value; }
        }


        public Dossier(string nom, string prenom, int nbEnfant, int salaire, int loyer, int dette = 0)
        {
            Nom = nom;
            Prenom = prenom;
            NbEnfant = nbEnfant;
            Salaire = salaire;
            Loyer = loyer;
            Dette = dette;
            ElligibleLogement = false;
            ElligibleFamille = false;
        }
    }
}
