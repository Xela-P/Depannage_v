using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Depannage
{
    public class Produit_like : Produit
    {
        private int idLike;
        public Produit_Like() : base()
        {
            this.idlike = null;
        }

        public Produit_Like(int idPers, string nom, string prenom, string email, string mdp, string idLike) : base(idPers, nom, prenom, email, mdp)
        {
            this.idLike = idLike;
        }
        public Produit_Like(int idPers, string nom, string prenom, string email, string idLike) : base(idPers, nom, prenom, email)
        {
            this.idLike = idLike;
        }


        public Produit_Like(string nom, string prenom, string email, string mdp, string idLike) : base(nom, prenom, email, mdp)
        {
            this.idLike = idLike;
        }
        public string idLike
        {
            get => this.idLike; set => this.idLike = value;
        }
    }
}