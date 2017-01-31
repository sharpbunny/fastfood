using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
    abstract class Personnel
    {
        //attributs
        private string _nom;
        private string _prenom;


        //accesseur et muttateur
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }
        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        //methode

        public void ConsultePlanning()
        {
            Console.WriteLine(" consulte le planning ");
        }
    }
}
