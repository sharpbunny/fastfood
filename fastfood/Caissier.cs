using System;
using System.Collections.Generic;

namespace fastfood
{
    /// <summary>
	/// Classe de gestion des paiements.
	/// </summary>
	class Caissier:Personnel
    {
        // Attributs.

        // Constructeurs.

        // Accesseurs.
        

        // Méthodes.

        /// <summary>
        /// Paiement en espèces par le client.
        /// </summary>
        public static void EncaisserEspece(Commande commande)
        {
            double saisirEspeceClient = 0;
            double sommeARendre = 0;
            bool controleSaisie = false;

            AfficherTotalCassierEnCouleur(commande);

            Console.WriteLine("Entrer le montant du client : ");
            controleSaisie = double.TryParse(Console.ReadLine() ,out saisirEspeceClient);

            sommeARendre = saisirEspeceClient - commande.Total;

            if (sommeARendre > 0)
            {
                Console.WriteLine("La somme a rendre est de : " + sommeARendre + "euro.");
                commande.Paye = true;

            }
            if (sommeARendre < 0)
            {
                Console.WriteLine("Montant du client insuffisant, ou choisir un autre type de paiement");

            }
            
            if (sommeARendre == 0)
            {
                Console.WriteLine("Vous avez payé avec l'appoint");
                commande.Paye = true;
            }
           
            Console.ReadKey();
        }

        /// <summary>
        /// Paiement en carte bancaire par le client.
        /// </summary>
        public static void EncaisserCB(Commande commande)
        {
            string codeCarteCB = "";
            bool paiementValider = false;
            short compteurCB = 0;

            AfficherTotalCassierEnCouleur(commande);

            do
            {
                Console.WriteLine("Entrer le code CB en 4 chiffres (essai" + (compteurCB + 1) + ")");
                codeCarteCB = Console.ReadLine();
                while (codeCarteCB.Length > 4)
                {
                    Console.WriteLine("Code invalide (format incorrect). Saisir à nouveau le code en 4 chiffres.");
                    Console.WriteLine("Entrer le code CB en 4 chiffres : ");
                    codeCarteCB = Console.ReadLine();
                }
                if (codeCarteCB == "1234")
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
            string nomClientCheque = "";
            long iclientRIB = 0;
            string clientRIB = "";

            AfficherTotalCassierEnCouleur(commande);

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
            Console.WriteLine("Le chèque est validé");
            Console.ReadLine();
        }

        /// <summary>
        /// Permet d'afficher la somme totale dans la classe Caissier.
        /// </summary>
        /// <param name="commande"></param>
        private static void AfficherTotalCassierEnCouleur(Commande commande)
        {
            commande.CalculerTotalCommande();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nVous devez payer : " + commande.Total + "euro(s).\n");
            Console.ResetColor();
        }
    }
}
