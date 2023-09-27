using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{

    
    public partial class Form_Gestion_Vehicule_E : Form
    {
        string n_fourriere;
        private string v;

        public Form_Gestion_Vehicule_E(string v)
        {
            InitializeComponent();
            L_User_Connecter.Text = v;
        }


        //methode pour get l'utilisateur connecté
        public String getuser()
        {
            //return CIN "Login" d'utilisateur
            return L_User_Connecter.Text;
        }

        public void Remplir_dataGridView_Gestion_Fourriere()
        {
            List<Vehicule> vehicule = VehiculeADO.GetVehicule();
            List<Vehicule> veh = new List<Vehicule>();
            foreach (var V in vehicule)
            {

                if ((V.Login_Agent == int.Parse(L_User_Connecter.Text) && V.Date_Sortiee == null && V.Nom_Fourriere == n_fourriere))
                {
                    veh.Add(V);
                    dataGridView_Gestion_vehicule_E.DataSource = veh.Select(v => new { Immatriculation = v.Immatriculation, Marque_Vehicule = v.Marque, DATE_ENTREE = v.Date_entree, NOM_FOURRIERE = v.Nom_Fourriere }).ToList();
                }


            }
        }

        private void Form_Gestion_Vehicule_E_Load(object sender, EventArgs e)
        {

            //agent contient Liste de l'agent
            List<Agent> agent = AgentADO.GetAgent();

            foreach (var A in agent)
            {
                if ((A.Login_Agent == int.Parse(L_User_Connecter.Text)))
                {
                    L_Nom_User.Text = A.Nom;
                    L_Prenom_User.Text = A.Prenom;
                    L_Email_User.Text = A.Email;
                    T_Nom_Fourriere.Text = A.Nom_Fourriere;
                    n_fourriere = A.Nom_Fourriere;
                }

            }

            //Date systéme
            DateTime d = DateTime.Now.Date;
            //T_Date_Entree.Text = d.ToString();
            T_Date_Entree.Text = d.ToShortDateString();

            Remplir_dataGridView_Gestion_Fourriere();

        }



        private void dataGridView_Gestion_vehicule_E_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView_Gestion_vehicule_E.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                T_Immatriculation.Text = row.Cells[0].Value.ToString();
                T_Marque.Text= row.Cells[1].Value.ToString();
               // T_Date_Entree.Text = row.Cells[2].Value.ToString();
                T_Nom_Fourriere.Text = row.Cells[3].Value.ToString();

            }
        }

        public void vide_champs()
        {
            T_Immatriculation.Clear();
            T_Marque.Clear();

        }
        private void btn_Ajouter_Fourriere_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(T_Immatriculation.Text.Trim().Equals("") || T_Marque.Text.Trim().Equals("")))
                {


                    Vehicule vehicule = new Vehicule();
                    vehicule.Immatriculation = T_Immatriculation.Text;
                    vehicule.Marque = T_Marque.Text;
                    vehicule.Date_entree= DateTime.Now.Date;
                    vehicule.Nom_Fourriere = T_Nom_Fourriere.Text;
                    vehicule.Login_Agent = int.Parse(L_User_Connecter.Text);
                    VehiculeADO.Ajouter_Vehicule(vehicule);
                    MessageBox.Show("Données enrg avec succées");
                    Remplir_dataGridView_Gestion_Fourriere();

                    //Videer les champs
                    vide_champs();

                }
                else
                {
                    MessageBox.Show("verifier votre champs vide");

                }
            }
            catch
            {
                MessageBox.Show("Véhicule déja existe , vérifier votre données");
                // L_erreur_Fourriere.Text = "Véhicule déja existe , vérifier votre données";
            }


        }

        private void btn_icon_clear_Click(object sender, EventArgs e)
        {
            vide_champs();
        }

        private void btn_Modifier_vehicule_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(T_Immatriculation.Text.Trim().Equals("") || T_Marque.Text.Trim().Equals("")))
                {

                    Vehicule f = new Vehicule();
                    VehiculeADO.Modifier_vehicule(T_Immatriculation.Text, T_Marque.Text);
                    MessageBox.Show("Véhicule modifier avec Succées");

                    Remplir_dataGridView_Gestion_Fourriere();
                    vide_champs();

                }
                else
                {
                    MessageBox.Show("verifier votre champs vide");
                }

            }
            catch
            {
                MessageBox.Show("Véhicule n'existe pas , verifier votre données");
                //L_erreur_Fourriere.Text = "vehicule n'existe pas , verifier votre données";
            }


        }

        private void btn_Supprimer_vehicule_Click(object sender, EventArgs e)
        {


            try
            {

                if (!(T_Immatriculation.Text.Trim().Equals("")))
                {

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Vous voulez supprimer ?", " ", buttons);
                    if (result == DialogResult.Yes)
                    {

                        VehiculeADO.Supprimer_Vehicule(T_Immatriculation.Text);
                        MessageBox.Show("Véhicule Supprimer avec Succées");

                    }
                    else
                    {
                        return;
                    }

                    Remplir_dataGridView_Gestion_Fourriere();
                    vide_champs();

                }
                else
                {
                    MessageBox.Show("champs immatriculation de vehicule est vide ");
                }
            }
            catch
            {

                MessageBox.Show("Vehicule n'existe pas , verifier votre données");
                //L_erreur_Fourriere.Text = "Vehicule n'existe pas , verifier votre données";
            }

        }

        private void btn_Montant_Click(object sender, EventArgs e)
        {
            Form_Enrg_Montant M_Compte = new Form_Enrg_Montant(this.getuser());
            M_Compte.Show();
            this.Hide();
        }

        private void btn_Gestion_Vehicule_E_Click(object sender, EventArgs e)
        {
            Form_Gestion_Vehicule_E G_Vehicule_E = new Form_Gestion_Vehicule_E(this.getuser());
            G_Vehicule_E.Show();
            this.Hide();
        }

        private void btn_Gestion_Vehicule_S_Click(object sender, EventArgs e)
        {
            Form_Gestion_Vehicule_S G_Vehicule_S = new Form_Gestion_Vehicule_S(this.getuser());
            G_Vehicule_S.Show();
            this.Hide();
        }

        private void btn_Mon_Compte_Click(object sender, EventArgs e)
        {
            Form_Mon_Compte_Agent M_Compte = new Form_Mon_Compte_Agent(this.getuser());
            M_Compte.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form_Authentification M_Compte = new Form_Authentification();
            M_Compte.Show();
            this.Hide();
        }

        private void btn_icon_home_Click(object sender, EventArgs e)
        {
            Dashboard_Agent M_Compte = new Dashboard_Agent(this.getuser());
            M_Compte.Show();
            this.Hide();
        }
    }
}