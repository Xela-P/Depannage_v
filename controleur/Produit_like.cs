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

        public Produit_Like(int idProduit, string nom, string composition, string type, string couleur, string idLike) : base(idProduit, nom, composition, type, couleur)
        {
            this.idLike = idLike;
        }
        public Produit_Like(string nom, string composition, string type, string couleur, string idLike) : base(nom, composition, type, couleur)
        {
            this.idLike = idLike;
        }
        public string idLike
        {
            get => this.idLike; set => this.idLike = value;
        }
    }
}