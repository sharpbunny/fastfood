using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
    class Caissier:Personnel
    {
        // Attributs.
        // Attributs pour EncaisserEspece
        int saissirEspeceClient = 0;
        int sommeTotalCommande = 0;
        int sommeRestant = 0; //Apres avoir compter le nimbre de billet de 10E à rendre
        int compteur10E = 0;
        int compteur5E = 0;
        int sommeARendreEnPiece = 0;

        // Constructeurs.

        // Accesseurs.   

        // Methodes.
        /// <summary>
        /// Paiement en especes par le client
        /// </summary>
        public void EncaisserEspece()
        {
            
            int sommeARendre = saissirEspeceClient - sommeTotalCommande;

            if(sommeARendre>0)
            {
                
                while (sommeARendre > 10)
                {
                    sommeRestant = sommeARendre - 10;
                    compteur10E++;                    
                }
                if (sommeRestant > 5)
                {
                    sommeARendreEnPiece = sommeRestant - 5;
                    compteur5E++; 
                }
                    
            }
            
        }
        /// <summary>
        /// Paiement en carte bancaire par le client
        /// </summary>
        public void EncaisserCB()
        {

        }
        /// <summary>
        /// Paiement cheque par la client
        /// </summary>
        public void EncaisserCheque()
        {
            
        }
    }
}
