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
        public Client()
        {
            this.idClient = 0;
            this.nom ="";
            this.prenom ="";
            this.adresse ="";
            this.mail = "";
            this.mdp = "";
        }

        public Client(int idClient, string nom, string prenom, string mail, string mdp, string adresse)
        {
            this.idClient = idClient;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.mail = mail;
            this.mdp = mdp;
        }

        public Client(int idClient, string nom, string prenom, string mail, string adresse)
         {
            this.idClient = 0;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.mail = mail;
            this.mdp = mdp;
        }




        public Client(string nom, string prenom, string mail, string mdp, string adresse)
         {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.mail = mail;
            this.mdp = mdp;
        }

        public string adresse
        {
            get => this.adresse; set => this.adresse = value;
        }
        public string idClient
        {
            get => this.idClient; set => this.idClient = value;
        }
        public string nom
        {
            get => this.nom; set => this.nom = value;
        }
        public string prenom
        {
            get => this.prenom; set => this.prenom = value;
        }
        public string mail
        {
            get => this.mail; set => this.mail = value;
        }
        public string mdp
        {
            get => this.mdp; set => this.mdp = value;
        }
    }
}