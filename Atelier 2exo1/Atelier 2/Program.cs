using System;
using System.Collections.Generic;


namespace Atelier_2
{

    class Program
    {

        public static List<Article> ArticleStock = new List<Article>();

        static void Main(string[] args)
        {
            // Object 1 
            Article x = new Article();

            int op1;
            int y = -1;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("/////////// Les Options //////////");
                Console.WriteLine("1 - Ajouter un article");
                Console.WriteLine("2 - Afficher tous les Articles du magasin.");
                Console.WriteLine("3 - Rechercher un Article par nom ou numéro de référence.");
                Console.WriteLine("4 - Afficher les Articles dont le prix d’achat est supérieur à une valeur saisie.");
                Console.WriteLine("5 - Supprimer un Article.");
                Console.WriteLine("6 - Modifier un Article.");
                Console.WriteLine("7 - Quitter le programe.");
                Console.WriteLine("==> Choisissez une option !");
                Console.WriteLine("");


                op1 = Int32.Parse(Console.ReadLine());

                switch (op1)
                {
                    case 1:
                        Stock.Ajouter(x);
                        break;

                    case 2:
                        Stock.Afficher();
                        break;

                    case 3:

                        int num = -1;
                        string nom = "";
        

                        Console.WriteLine(" Rechercher un article par (1) Numéro    (2) Nom .");

                        int choix = Int32.Parse(Console.ReadLine());
                        if(choix == 1)
                        {
                             Stock.Chercher(num);
                        } else if (choix == 2)
                        {
                            Stock.Chercher(nom);
                        }

                        
                        break;

                    case 4:
                        Stock.Comparer(y);
                        break;

                    case 5:
                        Stock.Suprimer(y);
                        break;

                    case 6:
                        Stock.Modifier(y);
                        break;

                    case 7:
                        Stock.Quitter();
                        break;

                    default:
                        Console.WriteLine(" Votre choix d'option est incorrecte !");
                        break;
                }

            }
            while (op1 != 7);
            Console.ReadKey();
        }
    }
}

