﻿using System;
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

        int saisirEspeceClient = 0;
        int sommeTotalCommande = 0;
        int sommeARendreEnBilletdeDix = 0;
        int sommeARendreEnBilletdeCinq = 0;
        int sommeARendreEnPiece = 0;
        int compteur10E = 0;
        int compteur5E = 0;

        //Attributs pour EncaisserCB
        int codeCarteCB;
        bool paiementValider = false;


        // Constructeurs.

        // Accesseurs.   

        public int CodeCarteCB
        {
            get
            {

                return codeCarteCB;
            }
                        
        }

        // Methodes.
        /// <summary>
        /// Paiement en especes par le client
        /// </summary>
        public void EncaisserEspece()
        {
            //Calcul pour avoir la somme à rendre au client
            sommeARendreEnBilletdeDix = saisirEspeceClient - sommeTotalCommande; 

            if(sommeARendreEnBilletdeDix > 0)
            {
                
                while (sommeARendreEnBilletdeDix >= 10)
                {
                    sommeARendreEnBilletdeCinq = sommeARendreEnBilletdeDix - 10;
                    compteur10E++;                    
                }
                if (sommeARendreEnBilletdeCinq >= 5)
                {
                    sommeARendreEnPiece = sommeARendreEnBilletdeCinq - 5;
                    compteur5E++; 
                }
                    
            }
            
            
        }
        /// <summary>
        /// Paiement en carte bancaire par le client
        /// </summary>
        public void EncaisserCB(int codeCarteCB)
        {
            if (codeCarteCB == 1234)
            {
                paiementValider = true;
            }
           
        }
        /// <summary>
        /// Paiement cheque par la client
        /// </summary>
        public void EncaisserCheque()
        {
            
        }
    }
}
