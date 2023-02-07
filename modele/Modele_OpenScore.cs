using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace Blank
{
    public class Modele_OpenScore
    {
        private string serveur, bdd, user, mdp;
        private MySqlConnection maConnexion;
        public Modele(string serveur, string bdd, string user, string mdp) 
        {
            this.serveur = serveur;
            this.bdd = bdd;
            this.user = user;
            this.mdp = mdp;
            string url = "SslMode=None; SERVER=" + this.serveur+"; Database="+this.bdd+"; User Id ="+this.user+"; Password="+this.mdp;

            try
            {
                this.maConnexion = new MySqlConnection(url);
            }
            catch (Exception exp) 
            { 
                Debug.WriteLine("Erreur de connexion a : "+url);
            }

        }

        public void InsertClient(Client unClient)
        {
            string requete = "call insertClient(@nom,@prenom,@email, @mdp, @adresse);";
            MySqlCommand uneCmde = null;
            try
            {
                this.maConnexion.Open();
                uneCmde = this.maConnexion.CreateCommand();
                uneCmde.CommandText = requete;
                //les correspondances entre variables Mysql et C#
                uneCmde.Parameters.AddWithValue("@nom", unClient.Nom);
                uneCmde.Parameters.AddWithValue("@prenom", unClient.Prenom);
                uneCmde.Parameters.AddWithValue("@email", unClient.Email);
                uneCmde.Parameters.AddWithValue("@mdp", unClient.Mdp);
                uneCmde.Parameters.AddWithValue("@adresse", unClient.Adresse);
                uneCmde.ExecuteNonQuery();
                this.maConnexion.Close();
            }
            catch (Exception exp)
            {
                Debug.WriteLine(uneCmde.CommandText);
                foreach (MySqlParameter unParam in uneCmde.Parameters)
                {
                    Debug.WriteLine(unParam.ParameterName + ": "+ unParam.Value);
                }
                Debug.WriteLine("Erreur de requete :" + requete);
                Debug.WriteLine(exp.Message);
            }
        }

        public void InsertLike(Produit_Like unProduit_Like)
        {
            string requete = "insert into ProduitLike values(nul, @materiel,@prix,@dateinter, @idclient, @idtechnicien);";
            MySqlCommand uneCmde = null;
            try
            {
                this.maConnexion.Open();
                uneCmde = this.maConnexion.CreateCommand();
                uneCmde.CommandText = requete;
                //les correspondances entre variables Mysql et C#
                uneCmde.Parameters.AddWithValue("@materiel", unProduit_Like.Materiel);
                uneCmde.Parameters.AddWithValue("@prix", unProduit_Like.Prix);
                uneCmde.Parameters.AddWithValue("@dateinter", unProduit_Like.Dateinter);
                uneCmde.Parameters.AddWithValue("@idclient", unProduit_Like.IdPersC);
                uneCmde.Parameters.AddWithValue("@idtechnicien", unProduit_Like.IdPersT);
                uneCmde.ExecuteNonQuery();
                this.maConnexion.Close();
            }
            catch (Exception exp)
            {
                Debug.WriteLine(uneCmde.CommandText);
                foreach (MySqlParameter unParam in uneCmde.Parameters)
                {
                    Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                }
                Debug.WriteLine("Erreur de requete :" + requete);
                Debug.WriteLine(exp.Message);
            }
        }







        public void DeleteProduit_like(int idLike)
        {
            string requete = "delete from Produit_Like where idLike = @idLike && idclient = @idclient;";
            MySqlCommand uneCmde = null;
            try
            {
                this.maConnexion.Open();
                uneCmde = this.maConnexion.CreateCommand();
                uneCmde.CommandText = requete;

                uneCmde.Parameters.AddWithValue("@idinter", idInter);
                uneCmde.ExecuteNonQuery();
                this.maConnexion.Close();
            }
            catch (Exception exp)
            {
                Debug.WriteLine(uneCmde.CommandText);
                foreach (MySqlParameter unParam in uneCmde.Parameters)
                {
                    Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                }
                Debug.WriteLine("Erreur de requete :" + requete);
                Debug.WriteLine(exp.Message);
            }

        }




        public void UpdateClient(Client unClient)
        {
            string requete = "call updateClient(@idpers, @nom, @prenom, @email, @adresse);";
            MySqlCommand uneCmde = null;
            try
            {
                this.maConnexion.Open();
                uneCmde = this.maConnexion.CreateCommand();
                uneCmde.CommandText = requete;
                //les correspondances entre variables MYSQL ET C#
                uneCmde.Parameters.AddWithValue("@idpers", unClient.IdPers);

                uneCmde.Parameters.AddWithValue("@nom", unClient.Nom);
                uneCmde.Parameters.AddWithValue("@prenom", unClient.Prenom);
                uneCmde.Parameters.AddWithValue("@email", unClient.Email);
                uneCmde.Parameters.AddWithValue("@adresse", unClient.Adresse);
                uneCmde.ExecuteNonQuery();
                this.maConnexion.Close();
            }
            catch (Exception exp)
            {
                Debug.WriteLine(uneCmde.CommandText);
                foreach (MySqlParameter unParam in uneCmde.Parameters)
                {
                    Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                }
                Debug.WriteLine("Erreur de requete :" + requete);
                Debug.WriteLine(exp.Message);
            }
        }

        public void UpdateIntervention(Intervention unProduit_Like)    
        {
            string requete = "update intervention set materiel = @materiel, prix = @prix, dateinter = @dateinter, idclient = @idclient, idtechnicien = @idtechnicien where idinter = @idinter;";
            MySqlCommand uneCmde = null;
            try
            {
                this.maConnexion.Open();
                uneCmde = this.maConnexion.CreateCommand();
                uneCmde.CommandText = requete;
                //les correspondances entre variables MYSQL ET C#
                uneCmde.Parameters.AddWithValue("@idinter", unProduit_Like.IdInter);

                uneCmde.Parameters.AddWithValue("@materiel", unProduit_Like.Materiel);
                uneCmde.Parameters.AddWithValue("@prix", unProduit_Like.Prix);
                uneCmde.Parameters.AddWithValue("@dateinter", unProduit_Like.Dateinter);
                uneCmde.Parameters.AddWithValue("@idclient", unProduit_Like.IdPersC);
                uneCmde.Parameters.AddWithValue("@idtechnicien", unProduit_Like.IdPersT);
                uneCmde.ExecuteNonQuery();
                this.maConnexion.Close();
            }
            catch (Exception exp)
            {
                Debug.WriteLine(uneCmde.CommandText);
                foreach (MySqlParameter unParam in uneCmde.Parameters)
                {
                    Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                }
                Debug.WriteLine("Erreur de requete :" + requete);
                Debug.WriteLine(exp.Message);
            }
        }





        public List<Client> SelectAllClient()
        {
            string requete = "select * from vueClients ;";
            List<Client> lesClients = new List<Client>();
            MySqlCommand uneCmde = null;
            try
            {
                this.maConnexion.Open();
                uneCmde = this.maConnexion.CreateCommand();
                uneCmde.CommandText = requete;

                //creation d'un curseur de résultats 
                DbDataReader unReader = uneCmde.ExecuteReader();
                try
                {
                    if (unReader.HasRows)
                    {
                        while (unReader.Read())
                        {
                            //instanciation d'un client
                            Client unClient = new Client(
                                unReader.GetInt16(0),
                                unReader.GetString(1),
                                unReader.GetString(2),
                                unReader.GetString(3),
                                unReader.GetString(4),
                                unReader.GetString(5)
                                );
                            //ajouter dans la liste
                            lesClients.Add(unClient);
                        }
                    }
                }
                catch (Exception exp)
                {
                    Debug.WriteLine(uneCmde.CommandText);
                    foreach (MySqlParameter unParam in uneCmde.Parameters)
                    {
                        Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                    }
                    Debug.WriteLine("Erreur de requete :" + requete);
                    Debug.WriteLine(exp.Message);
                }
                this.maConnexion.Close();
            }
            catch (Exception exp)
            {
                Debug.WriteLine(uneCmde.CommandText);
                foreach (MySqlParameter unParam in uneCmde.Parameters)
                {
                    Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                }
                Debug.WriteLine("Erreur de requete :" + requete);
                Debug.WriteLine(exp.Message);
            }
            return lesClients;
        }



        public List<Intervention> SelectAllIntervention()
        {
            string requete = "select * from intervention;";
            List<Intervention> lesInterventions = new List<Intervention>();
            MySqlCommand uneCmde = null;
            try
            {
                this.maConnexion.Open();
                uneCmde = this.maConnexion.CreateCommand();
                uneCmde.CommandText = requete;

                //creation d'un curseur de résultats 
                DbDataReader unReader = uneCmde.ExecuteReader();
                try
                {
                    if (unReader.HasRows)
                    {
                        while (unReader.Read())
                        {
                            //instanciation d'un client
                            Intervention unProduit_Like = new Intervention(
                                unReader.GetInt16(0),
                                unReader.GetString(1),
                                unReader.GetString(2),
                                unReader.GetString(3),
                                unReader.GetInt16(4),
                                unReader.GetInt16(5)
                                );
                            //ajouter dans la liste
                            lesInterventions.Add(unProduit_Like);
                        }
                    }
                }
                catch (Exception exp)
                {
                    Debug.WriteLine(uneCmde.CommandText);
                    foreach (MySqlParameter unParam in uneCmde.Parameters)
                    {
                        Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                    }
                    Debug.WriteLine("Erreur de requete :" + requete);
                    Debug.WriteLine(exp.Message);
                }
                this.maConnexion.Close();
            }
            catch (Exception exp)
            {
                Debug.WriteLine(uneCmde.CommandText);
                foreach (MySqlParameter unParam in uneCmde.Parameters)
                {
                    Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                }
                Debug.WriteLine("Erreur de requete :" + requete);
                Debug.WriteLine(exp.Message);
            }
            return lesInterventions;
        }




        public Client SelectWhereClient(int idClient)
        {
            string requete = "select * from vueClients where idpers = @idclient;";
            Client unClient = null;
            MySqlCommand uneCmde = null;
            try
            {
                this.maConnexion.Open();
                uneCmde = this.maConnexion.CreateCommand();
                uneCmde.CommandText = requete;
                uneCmde.Parameters.AddWithValue("@idclient", idClient);

                //creation d'un cruseur de résultats
                DbDataReader unReader = uneCmde.ExecuteReader();
                try
                {
                    if (unReader.HasRows)
                    {
                        if (unReader.Read())
                        {
                            //instanciation d'un client

                                unClient = new Client(
                                unReader.GetInt32(0),
                                unReader.GetString(1),
                                unReader.GetString(2),
                                unReader.GetString(3),
                                unReader.GetString(4),
                                unReader.GetString(5)
                                );
                        }
                    }
                }
                catch (Exception exp)
                {
                    Debug.WriteLine(uneCmde.CommandText);
                    foreach (MySqlParameter unParam in uneCmde.Parameters)
                    {
                        Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                    }
                    Debug.WriteLine("Erreur de requete :" + requete);
                    Debug.WriteLine(exp.Message);
                }
                this.maConnexion.Close();
            }
            catch (Exception exp)
            {
                Debug.WriteLine(uneCmde.CommandText);
                foreach (MySqlParameter unParam in uneCmde.Parameters)
                {
                    Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                }
                Debug.WriteLine("Erreur de requete :" + requete);
                Debug.WriteLine(exp.Message);
            }
            return unClient;

        }


        public Intervention SelectWhereIntervention(int idInter)
        {
            string requete = "select * from intervention where idinter = @idinter;";
            Intervention unProduit_Like = null;
            MySqlCommand uneCmde = null;
            try
            {
                this.maConnexion.Open();
                uneCmde = this.maConnexion.CreateCommand();
                uneCmde.CommandText = requete;
                uneCmde.Parameters.AddWithValue("@idinter", idInter);

                //creation d'un cruseur de résultats
                DbDataReader unReader = uneCmde.ExecuteReader();
                try
                {
                    if (unReader.HasRows)
                    {
                        if (unReader.Read())
                        {
                            //instanciation d'un client

                            unProduit_Like = new Intervention(
                                unReader.GetInt32(0),
                                unReader.GetString(1),
                                unReader.GetString(2),
                                unReader.GetString(3),
                                unReader.GetInt32(4),
                                unReader.GetInt32(5)
                            );
                        }
                    }
                }
                catch (Exception exp)
                {
                    Debug.WriteLine(uneCmde.CommandText);
                    foreach (MySqlParameter unParam in uneCmde.Parameters)
                    {
                        Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                    }
                    Debug.WriteLine("Erreur de requete :" + requete);
                    Debug.WriteLine(exp.Message);
                }
                this.maConnexion.Close();
            }
            catch (Exception exp)
            {
                Debug.WriteLine(uneCmde.CommandText);
                foreach (MySqlParameter unParam in uneCmde.Parameters)
                {
                    Debug.WriteLine(unParam.ParameterName + ": " + unParam.Value);
                }
                Debug.WriteLine("Erreur de requete :" + requete);
                Debug.WriteLine(exp.Message);
            }
            return unProduit_Like;

        }

    }
}