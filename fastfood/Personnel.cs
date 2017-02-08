using System;
namespace fastfood
{
    abstract class Personnel
    {
        // Attributs.
        private string _nom;
        private string _prenom;

        // Accesseurs et muttateurs.
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        // Methodes.
        public void ConsultePlanning()
        {
            Console.WriteLine(" consulte le planning ");
        }
        public void FaitLaGreve()
        {
            Console.WriteLine("PAS CONTENT ! PAS CONTENT ! PAS CONTENT !");
        }

        ///
        // test 
        ///
    }
}
