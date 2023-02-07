using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Depannage
{
public class Produit {
	
	protected int idProduit;
	protected String nom, composition, type, couleur;
	
	public Produit(int idProduit, String nom, String composition, String type, String couleur) {
		this.idProduit = idProduit;
		this.nom = nom;
		this.composition = composition;
		this.type = type;
		this.couleur = couleur;
	}
	
	public Produit(String nom, String composition, String type, String couleur) {
	
		this.nom = nom;
		this.composition = composition;
		this.type = type;
		this.couleur = couleur;
	}
	
	public int IdProduit() 
    {
		get => IdProduit; set => idProduit = value;
	}


	public String Nom() {
		get => nom; set => nom = value;
	}


	public String Composition() {
		get => Composition; set => Composition = value;
	}


	public String Type() {
		get => Type; set => Type = value;
	}

	
	public String Couleur() {
		get => Couleur; set => Couleur = value;
	}



}
}