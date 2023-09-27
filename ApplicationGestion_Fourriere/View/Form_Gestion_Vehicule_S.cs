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
    public partial class Form_Gestion_Vehicule_S : Form
    {
        string n_fourriere;
        private string v;
        public Form_Gestion_Vehicule_S(string v)
        {
            InitializeComponent();
            L_User_Connecter.Text = v;
        }


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
                
                if ((V.Login_Agent == int.Parse(L_User_Connecter.Text) && V.Date_Sortiee== null && V.Nom_Fourriere== n_fourriere))
                {
                    veh.Add(V);
                    dataGridView_Gestion_vehicule_E.DataSource = veh.Select(v => new { Immatriculation = v.Immatriculation, Marque_Vehicule = v.Marque, DATE_ENTREE = v.Date_entree, NOM_FOURRIERE = v.Nom_Fourriere, Les_Autres_Données = "pas encore completes" }).ToList();
                }

            }

        }

        private void dataGridView_Gestion_vehicule_E_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView_Gestion_vehicule_E.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                T_Immatriculation.Text = row.Cells[0].Value.ToString();
                T_Marque.Text = row.Cells[1].Value.ToString();
                T_Date_Entree.Text = row.Cells[2].Value.ToString();
                T_Nom_Fourriere.Text = row.Cells[3].Value.ToString();

            }
        }

        private void Form_Gestion_Vehicule_S_Load(object sender, EventArgs e)
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
                    n_fourriere= A.Nom_Fourriere;
                }

            }

            //Date systéme
            DateTime d = DateTime.Now.Date;
            //T_Date_Entree.Text = d.ToString();
            T_Date_Sortie.Text = d.ToShortDateString();

            Remplir_dataGridView_Gestion_Fourriere();

        }

        private void T_Date_Entree_Click(object sender, EventArgs e)
        {

        }


        public void vide_champs()
        {
            T_Immatriculation.Clear();
            T_Marque.Clear();
            T_Date_Entree.Clear();
            T_Num_Cart_Crise.Clear();
            T_Nom_Prop_vehicule.Clear();
            T_CIN_Conducteur_Vehicule.Clear();
            T_Prix.Clear();

        }

        private void btn_Sortie_vehicule_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(T_Immatriculation.Text.Trim().Equals("") || T_Marque.Text.Trim().Equals("") || T_Date_Entree.Text.Trim().Equals("") || T_Nom_Fourriere.Text.Trim().Equals("") || T_Num_Cart_Crise.Text.Trim().Equals("") ||T_Nom_Prop_vehicule.Text.Trim().Equals("") ||T_CIN_Conducteur_Vehicule.Text.Trim().Equals("") ||T_Prix.Text.Trim().Equals("") ||T_Date_Sortie.Text.Trim().Equals("")))
                {

                    Vehicule f = new Vehicule();
                    VehiculeADO.Modifier_vehicule_Sortie(T_Immatriculation.Text, T_Num_Cart_Crise.Text,T_Nom_Prop_vehicule.Text,T_CIN_Conducteur_Vehicule.Text,T_Prix.Text,T_Date_Sortie.Text);
                    MessageBox.Show("Véhicule Enregistrer en statut sortie avec Succées");

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

        private void btn_icon_clear_Click(object sender, EventArgs e)
        {
            vide_champs();
            T_Immatriculation.Text = "Immatriculation";
            T_Marque.Text = "Marque de véhicule";
            T_Date_Entree.Text = "Date entrée";
        }
    }
}
