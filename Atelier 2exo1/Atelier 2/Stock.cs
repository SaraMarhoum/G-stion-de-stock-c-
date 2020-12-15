using System;
using System.Collections.Generic;

namespace Atelier_2
{

    public class Stock
    {
        public static List<Article> ArticleStock = new List<Article>();

        // 0 Fonction chercher un article et retourner son index
        static int Look(List<Article> L, int a)
        {
            int b = -1;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].refNum == a)
                {
                    b = i;
                    break;
                }
            }
            return b;
        }

        // 0 Fonction chercher un article par nom et retourner son index
        static int LookNom(List<Article> L, string a)
        {
            int b = -1;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].Nom == a)
                {
                    b = i;
                    break;
                }
            }
            return b;
        }


        // 1 Ajouter un article.  
        public static void Ajouter(Article article)
        {

            article.refNum++;

            Console.WriteLine("Entrez un nom d'article.");
            article.Nom = Console.ReadLine();

            Console.WriteLine("Entrez son prix d'achat.");
            article.prixAchat = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entrez son prix de vente.");
            article.prixVente = Int32.Parse(Console.ReadLine());

            ArticleStock.Add(new Article(article.refNum, article.Nom, article.prixAchat, article.prixVente));
            Console.WriteLine("Article Ajouté avec succès !");
        }




        // 2 Afficher les articles
        public static void Afficher()
        {

            Console.WriteLine("******** Liste des articles ********");
            foreach (var article in ArticleStock)
            {
                article.Info();
            }
            if (ArticleStock.Count == 0)
            {
                Console.WriteLine("Aucun résultat n'a été trouvé !");
            }

        }



        // 3 Rechercher un Article par num

        public static void Chercher(int refNum)
        {


            int b;

            Console.WriteLine(" Veuillez entrer le numéro de référence de l'article à chercher !");
            refNum = Int32.Parse(Console.ReadLine());



            b = Look(ArticleStock, refNum);
            if (b == -1)
            {
                Console.WriteLine(" Cet article n'existe pas dans le stock !");
            }
            else
            {
                Console.WriteLine(ArticleStock[b]);
                Console.WriteLine("L'article au numéro de référence: " + refNum + " éxiste bien.");

            }


        }

        // 3 Rechercher un Article par nom
        public static void Chercher(string nom)
        {
            int b;

            Console.WriteLine(" Veuillez entrer le nom de l'article à chercher !");
            nom = Console.ReadLine();



            b = LookNom(ArticleStock, nom);
            if (b == -1)
            {
                Console.WriteLine(" Cet article n'existe pas dans le stock !");
            }
            else
            {
                Console.WriteLine(ArticleStock[b]);
                Console.WriteLine("L'article au numéro de référence: " + nom + " éxiste bien.");

            }
        }


        // 4 Afficher les Articles dont le prix d’achat est supérieur à une valeur saisies
        public static void Comparer(int testNum)
        {
            Console.WriteLine(" Veuillez entrer une valeure pour comparer le prix d'achat !");
            testNum = Int32.Parse(Console.ReadLine());

            foreach (var article in ArticleStock)
            {
                if (article.prixAchat > testNum)
                {
                    article.Info();
                }

            }
        }




        // 5 Supprimer un Article
        public static void Suprimer(int refNum)
        {
            int b;

            Console.WriteLine(" Veuillez entrer le numéro de référence de l'article à suprimer !");
            refNum = Int32.Parse(Console.ReadLine());

            //Vérifier si l'article existe déjà 
            b = Look(ArticleStock, refNum);
            if (b == -1)
            {
                Console.WriteLine("Cet article n'existe pas !");
            }
            else
            {
                ArticleStock.RemoveAt(b);
                Console.WriteLine("L'article a été suprimé avec succès !");
            }
        }




        // 6 Modifier un Article
        public static void Modifier(int refNum)
        {
            int b;

            Console.WriteLine(" Veuillez entre le numéro de référence de l'article à modifier !");

            //Vérifier que l'article existe 
            refNum = Int32.Parse(Console.ReadLine());

            b = Look(ArticleStock, refNum);
            if (b == -1)
            {
                Console.WriteLine("Cet article n'existe pas !");
            }

            else
            {
                int op;
                do
                {
                    Console.WriteLine("/////////// Les Options //////////");
                    Console.WriteLine("1 - Modifier le numéro de référence");
                    Console.WriteLine("2 - Modifier le nom");
                    Console.WriteLine("3 - Modifier le prix d'acchat");
                    Console.WriteLine("4 - Modifier le prix de vente");
                    Console.WriteLine("5 - Finir la modification");
                    Console.WriteLine("==> Choisissez une option !");

                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("1 - Modifier le numéro de référence");
                            ArticleStock[b].refNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Numéro de l'article modifié avec succès !");
                            break;

                        case 2:
                            Console.WriteLine("1 - Modifier le nom");
                            ArticleStock[b].Nom = Console.ReadLine();
                            Console.WriteLine("Nom de l'article modifié avec succès !");
                            break;

                        case 3:
                            Console.WriteLine("1 - Modifier le prix d'achat");
                            ArticleStock[b].prixAchat = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Prix d'achat de l'article modifié avec succès !");
                            break;

                        case 4:
                            Console.WriteLine("1 - Modifier le prix de vente");
                            ArticleStock[b].prixVente = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Prix de vente de l'article modifié avec succès !");
                            break;

                        case 5:
                            Console.WriteLine("Modifications términées !");
                            break;

                        default:
                            Console.WriteLine("Votre choix est introuvable !");
                            break;
                    }
                }

                while (op != 5);
            }

        }



        // 7  Quitter le programme
        public static void Quitter()
        {
            Console.WriteLine("Fin du programme !");
        }
    }

}
