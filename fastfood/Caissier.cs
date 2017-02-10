using System;
using System.Collections.Generic;

namespace fastfood
{
    /// <summary>
	/// Classe de gestion des paiements
	/// </summary>
	class Caissier:Personnel
    {
        // Attributs.
        // Attributs pour EncaisserEspece.
        

        // Attributs pour EncaisserCB.
        

        // Attributs pour EncaisserCheque.
        




        // Constructeurs.

        // Accesseurs.
        

        // Méthodes.
        /// <summary>
        /// Paiement en espèces par le client.
        /// </summary>
        public static void EncaisserEspece(Commande commande)
        {
            int saisirEspeceClient = 0;
            int sommeTotalCommande = 0;
            int sommeARendre = 0;
            //int sommeARendreEnBilletdeCinq = 0;
            int sommeARendreEnPiece = 0;
            int compteur10E = 0;
            int compteur5E = 0;

            //Console.WriteLine("Entrer le montant à payer : ");
            //sommeTotalCommande = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrer le montant du client : ");
            saisirEspeceClient = int.Parse(Console.ReadLine());

            sommeARendre = saisirEspeceClient - sommeTotalCommande;

            if (sommeARendre > 0)
            {
                Console.WriteLine("La somme a rendre est de : " + sommeARendre + "euro.");

                while (sommeARendre >= 10)
                {
                    sommeARendre = sommeARendre - 10;
                    compteur10E++;
                }
                if (sommeARendre >= 5)
                {
                    sommeARendreEnPiece = sommeARendre - 5;
                    compteur5E++;
                }
            }
            if (sommeARendre == 0)
            {
                Console.WriteLine("Vous avez payé avec l'appoint");
				commande.Paye = true;
            }

            if (sommeARendre < 0)
            {
                Console.WriteLine("Montant du client insuffisant, ou choisir un autre type de paiement");
            }

            if (compteur10E >= 1)
            {
                Console.WriteLine("Nombre de billet(s) de 10 euro à rendre : " + compteur10E + ".");
            }
            if (compteur5E >= 1)
            {
                Console.WriteLine("Nombre de billet(s) de 5 euro à rendre : " + compteur5E + ".");
            }
            if (sommeARendreEnPiece > 0)
            {
                Console.WriteLine("Monnaie à rendre : " + sommeARendreEnPiece + "euro.");
            }
            commande.Paye = true;
            Console.ReadKey();
        }

        /// <summary>
        /// Paiement en carte bancaire par le client.
        /// </summary>
        public static void EncaisserCB(Commande commande)
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
                    Console.WriteLine("Code invalide (format incorrect). Saisir à nouveau le code en 4 chiffres.");
                    Console.WriteLine("Entrer le code CB en 4 chiffres : ");
                    codeCarteCB = int.Parse(Console.ReadLine());
                }
                if (codeCarteCB == 1234)
                {
                    
                    Console.WriteLine("Le code est correct. Paiement accepté.");
                    Console.ReadKey();
                    paiementValider = true;
					commande.Paye = true;
                }
                compteurCB++;
            }
            while (compteurCB < 3 && !paiementValider);

            if (compteurCB > 3 || paiementValider == false)
            {
                Console.WriteLine("Le paiement par CB est refusé");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Paiement chèque par la client.
        /// </summary>
        public static void EncaisserCheque(Commande commande)
        {
            List<string> newCheque = new List<string>();
            bool etatCheque = false;
            double imontantCheque = 0;
            string montantCheque = "";
            string nomClientCheque = "";
            long iclientRIB = 0;
            string clientRIB = "";

            Console.WriteLine("Entrer le montant du chèque à encaisser : ");
            montantCheque = Console.ReadLine();
            do
            {
                etatCheque = double.TryParse(montantCheque, out imontantCheque);

                if (!etatCheque)
                {
                    Console.WriteLine("Entrer à nouveau un montant correct : ");
                    montantCheque = Console.ReadLine();
                }
                else
                {
                    etatCheque = true;
                }
            }
            while (!etatCheque);

            Console.WriteLine("Entrer le nom du client à qui appartient le chèque : ");
            nomClientCheque = Console.ReadLine();

            etatCheque = false;
            do
            {
                Console.WriteLine("Entrer le RIB du client : ");
                clientRIB = Console.ReadLine();
                etatCheque = long.TryParse(clientRIB, out iclientRIB);
                if (clientRIB.Length == 11 && etatCheque == true)
                {
                    etatCheque = true;
                }
                else
                {
                    etatCheque = false;
                }
                while (!etatCheque)
                {
                    if (clientRIB.Length != 11)
                    {
                        Console.WriteLine("Entrer à nouveau le RIB correct : ");
                        clientRIB = Console.ReadLine();
                    }
                    else
                    {
                        etatCheque = true;
                    }

                }

            }
            while (!etatCheque);

            commande.Paye = true;
        }
        public void CalculerTotalCommande(Commande commande)
        {
            double Total = 0;
            
            for (short i = 0; i < commande.ListeArticle.Length; i++)
            {
                
                Total += commande.ListeArticle[i].Prix;
            }
            commande.Total = Total;
        }

        

    }
}
