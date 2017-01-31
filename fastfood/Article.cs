using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
	class Article
	{
		protected int _IDArticle;
		protected string _nom;
		protected float _prix;

		// Getters & Setters
		protected int IDArticle
		{
			get { return _IDArticle; }
			set { _IDArticle = value; }
		}
	
		protected string Nom
		{ get { return _nom; }
		  set{ _nom = value; }
		}

		public float Prix
		{ get{ return _prix; }
		set{ _prix = value; }
		}

		protected enum MyEnum
		{
			Boisson,
			Burger,
			Glace,
			Salade,
			Sauce
		}
		
		//Constructors
		public Article(int _IDArticle, string _nom, float _prix)
		{
			this._nom = Nom;
			this._prix = Prix;
			this._IDArticle = IDArticle;
			
		}
	}
	

}
