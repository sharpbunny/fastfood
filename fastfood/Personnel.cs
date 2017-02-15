using System;
namespace fastfood
{
	abstract class Personnel
	{
		// Attributs.
		/// <summary>
		/// Nom du personnel.
		/// </summary>
		private string _nom;

		/// <summary>
		/// Prénom du personnel.
		/// </summary>
		private string _prenom;

		// Accesseurs et muttateurs.
		/// <summary>
		/// Le nom.
		/// </summary>
		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}


		/// <summary>
		/// Le prénom.
		/// </summary>
		public string Prenom
		{
			get { return _prenom; }
			set { _prenom = value; }
		}

		// Methodes.
		/// <summary>
		/// Consulter le planning.
		/// </summary>
		public void ConsultePlanning()
		{
			Console.WriteLine(" consulte le planning ");
		}

		/// <summary>
		/// Exprimer son mécontentement !
		/// </summary>
		public void FaitLaGreve()
		{
			Console.WriteLine("PAS CONTENT ! PAS CONTENT ! PAS CONTENT !");
		}

	}
}
