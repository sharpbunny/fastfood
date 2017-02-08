using System;

namespace fastfood
{
    class Caissier:Personnel
    {
        // Attributs.
        // Attributs pour EncaisserEspece.
        

        // Attributs pour EncaisserCB.
        

        // Attributs pour EncaisserCheque.
        




        // Constructeurs.

        // Accesseurs.
        

        // Methodes.
        /// <summary>
        /// Paiement en especes par le client.
        /// </summary>
        public static void EncaisserEspece()
        {
            int saisirEspeceClient = 0;
            int sommeTotalCommande = 0;
            int sommeARendreEnBilletdeDix = 0;
            int sommeARendreEnBilletdeCinq = 0;
            int sommeARendreEnPiece = 0;
            int compteur10E = 0;
            int compteur5E = 0;

            //Calcul pour avoir la somme à rendre au client
            Console.WriteLine("Entrer le montant du client : ");
            saisirEspeceClient = int.Parse(Console.ReadLine());

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

            Console.WriteLine("La somme a rendre est de : " + sommeARendreEnBilletdeDix + "€.");

            if (compteur10E >= 1)
            {
                Console.WriteLine("Nombre de billet(s) de 10€ à rendre : " + compteur10E + ".");
                
            }
            if(compteur5E >=1)
            {
                Console.WriteLine("Nombre de billet(s) de 5€ à rendre : "+ compteur5E + ".");
            }
            else
            {
                Console.WriteLine("Monnaie à rendre : " + sommeARendreEnPiece + "€.");
            }

        }

        /// <summary>
        /// Paiement en carte bancaire par le client.
        /// </summary>
        public static void EncaisserCB()
        {
            int codeCarteCB = 0;
            bool paiementValider = false;
            short compteurCB = 0;

            do
            {
                Console.WriteLine("Entrer le code CB en 4 chiffres (essai" + (compteurCB + 1) + ")");
                codeCarteCB = int.Parse(Console.ReadLine());
                while (codeCarteCB >= 10000)
                {
                    Console.WriteLine("Code invalide (format incorrect) Saisir à nouveau le code en 4 chiffres.");
                    Console.WriteLine("Entrer le code CB en 4 chiffres : ");
                    codeCarteCB = int.Parse(Console.ReadLine());
                }
                if (codeCarteCB == 1234)
                {

                    paiementValider = true;
                    Console.WriteLine("Le code est correct.\nPaiement accepté.");

                }
                compteurCB++;
            }
            while (compteurCB < 3 && !paiementValider);

            if (compteurCB > 3 || paiementValider == false)
            {
                Console.WriteLine("Le paiement par CB est refusé");
            }
        }

        /// <summary>
        /// Paiement cheque par la client.
        /// </summary>
        public static void EncaisserCheque()
        {
            int montantCheque;
            string nomClientCheque;
            int clientRIB;

            Console.WriteLine("Entrer le montant du chèque : ");
            montantCheque = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer le nom du client à qui appartient le chèque : ");
            nomClientCheque = Console.ReadLine();
            Console.WriteLine("Entrer le RIB du client : ");
            clientRIB = int.Parse(Console.ReadLine());
            


        }
    }
}
