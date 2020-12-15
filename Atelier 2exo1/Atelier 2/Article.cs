using System;

namespace Atelier_2
{
    //Créer class
    public class Article
    {
        public int refNum;
        public string Nom;
        public int prixAchat;
        public int prixVente;


        public Article()
        {

        }

        //Créer constructeur
        public Article(int refNum, string Nom, int prixAchat, int prixVente)
        {
            this.refNum = refNum;
            this.Nom = Nom;
            this.prixAchat = prixAchat;
            this.prixVente = prixVente;


            try
            {
                if (prixVente > prixAchat)
                {
                    this.prixVente = prixVente;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Attention !! Le prix de vente est inferieur au prix d'achat ! : {0}", ex.Message);
            }

        }


        //Method to return object's values
        public void Renvoie()
        {
            Console.WriteLine("L'article " + Nom + " numéro: " + refNum + " a un prix d'achat : " + prixAchat + " et un prix de vente : " + prixVente);
        }

        public void Info()
        {

            Console.WriteLine("Article n° : " + refNum);
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Prix d'achat : " + prixAchat + " DH");
            Console.WriteLine("Prix de vente : " + prixVente + " DH");
            Console.WriteLine("");

        }
    }
}

