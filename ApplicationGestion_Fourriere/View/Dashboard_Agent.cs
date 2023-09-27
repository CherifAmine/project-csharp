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
    public partial class Dashboard_Agent : Form
    {
        private string v;
        public Dashboard_Agent(string v)
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

        private void Dashboard_Agent_Load(object sender, EventArgs e)
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

                }

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void btn_enrg_Montant_Click(object sender, EventArgs e)
        {
            Form_Enrg_Montant M_Compte = new Form_Enrg_Montant(this.getuser());
            M_Compte.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form_Authentification M_Compte = new Form_Authentification();
            M_Compte.Show();
            this.Hide();
        }
    }
}
