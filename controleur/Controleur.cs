using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Depannage
{
    public class Controleur
    {
        private static Modele unModele = new Modele("localhost", "depannage_sd_23", "root", "");

        public static void InsertClient(Client unClient)
        {
            unModele.InsertClient(unClient);
        }

        public static void InsertProduit_Like(Produit_Like unProduit_Like)
        {
            unModele.InsertProduit_Like(unProduit_Like);
        }


        public static void DeleteProduit_Like(int idinter)
        {
            unModele.DeleteProduit_Like(idinter);
        }

        public static void UpdateClient(Client unClient)
        {
            unModele.UpdateClient(unClient);
        }

        public static Client SelectWhereClient(int idClient)
        {
            return unModele.SelectWhereClient(idClient);
        }

        public static Technicien SelectWhereTechnicien(string email, string mdp)
        {
            return unModele.SelectWhereTechnicien(email, mdp);
        }
        
       

        public static Produit_Like SelectWhereProduit_Like(int idInter)
        {
            return unModele.SelectWhereProduit_Like(idInter);
        }

        public static List<Client>SelectAllClient()
        {
            return unModele.SelectAllClient();
        }


    }
}