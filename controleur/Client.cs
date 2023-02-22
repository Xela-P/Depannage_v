using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Depannage
{
    public class Client 
    {
        private int idClient;
        private string nom, prenom, adresse, mail, mdp;
        private List<Produit> mesProduits ; 
        public Client()
        {
            this.idClient = 0;
            this.nom ="";
            this.prenom ="";
            this.adresse ="";
            this.mail = "";
            this.mdp = "";
            this.mesProduits = new List<Produit>();
        }

        public Client(int idClient, string nom, string prenom, string mail, string mdp, string adresse)
        {
            this.idClient = idClient;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.mail = mail;
            this.mdp = mdp;
            this.mesProduits = new List<Produit>();
        }

        public Client(int idClient, string nom, string prenom, string mail, string adresse)
         {
            this.idClient = 0;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.mail = mail;
            this.mdp = mdp;
            this.mesProduits = new List<Produit>();
        }




        public Client(string nom, string prenom, string mail, string mdp, string adresse)
         {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.mail = mail;
            this.mdp = mdp;
        }

        public string Adresse
        {
            get => this.adresse; set => this.adresse = value;
        }
        public string IdClient
        {
            get => this.idClient; set => this.idClient = value;
        }
        public string Nom
        {
            get => this.nom; set => this.nom = value;
        }
        public string Prenom
        {
            get => this.prenom; set => this.prenom = value;
        }
        public string Mail
        {
            get => this.mail; set => this.mail = value;
        }
        public string Mdp
        {
            get => this.mdp; set => this.mdp = value;
        }
        public List<Produit> MesProduits
        {
            get => this.mesProduits; set => this.mesProduits = value;
        }
    }
}