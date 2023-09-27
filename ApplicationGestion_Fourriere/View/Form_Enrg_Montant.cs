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
    public partial class Form_Enrg_Montant : Form
    {
        public Form_Enrg_Montant(string v)
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

                if ((V.Login_Agent == int.Parse(L_User_Connecter.Text) && V.Date_Sortiee == DateTime.Now.Date && V.Nom_Fourriere==n_Fourriere))
                {
                    veh.Add(V);
                    dataGridView_Gestion_vehicule_E.DataSource = veh.Select(v => new { Immatriculation = v.Immatriculation, Marque_Vehicule = v.Marque, DATE_ENTREE = v.Date_entree, NOM_FOURRIERE = v.Nom_Fourriere }).ToList();
                }


            }
        }

        string n_Fourriere;
        private void Form_Enrg_Montant_Load(object sender, EventArgs e)
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
                    n_Fourriere = A.Nom_Fourriere;

                }

            }

   
            Remplir_dataGridView_Gestion_Fourriere();


        }
        float montant;

        private void btn_Enrg_Montant_Fourriere_Click(object sender, EventArgs e)
        {
            try
            {

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Vous voulez Enregistrer le montant ?", " ", buttons);
                    if (result == DialogResult.Yes)
                    {

                        List<Vehicule> vehicule = VehiculeADO.GetVehicule();
                        List<Vehicule> veh = new List<Vehicule>();

                        foreach (var V in vehicule)
                        {

                            if ((V.Login_Agent == int.Parse(L_User_Connecter.Text) && V.Date_Sortiee == DateTime.Now.Date))
                            {
                            montant = (float)(montant + V.Prix);
                            }


                        }

                    Montant m = new Montant();
                    m.Date_Montant = DateTime.Now.Date;
                    m.Montant1 = montant;
                    m.Nom_Fourriere = n_Fourriere;
                    m.Login_Agent=int.Parse(L_User_Connecter.Text);
                   
                    MontantADO.Enrg_Montant(m);

                    MessageBox.Show("Montant enregistrer avec succées");
                    Remplir_dataGridView_Gestion_Fourriere();


                }
                else
                    {
                        return;
                    }

                    Remplir_dataGridView_Gestion_Fourriere();


            }
            catch
            {
                MessageBox.Show("Erreur d'enregistrement ");
            }
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

        private void btn_enrg_Montant_Click(object sender, EventArgs e)
        {
            Form_Enrg_Montant M_Compte = new Form_Enrg_Montant(this.getuser());
            M_Compte.Show();
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
