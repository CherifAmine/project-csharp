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
    public partial class Dashboard_Admin : Form
    {
        private string v;

        public Dashboard_Admin(string v)
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


        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {

            //Admin contient Liste de l'administrateur
            List<Administrateur> Admin = AdministrateurADO.Get_Informations_Admin();

            foreach (var A in Admin)
            {
                if ((A.Login_Admin == int.Parse(L_User_Connecter.Text)))
                {
                    L_Nom_User.Text = A.Nom;
                    L_Prenom_User.Text = A.Prenom;
                    L_Email_User.Text = A.Email;

                }

            }


        }


        //Button Gestion de Fourriere si on click sur ce button il navigate vers la form Gestion de fourriere
        private void btn_Gestion_Fourriere_Click(object sender, EventArgs e)
        {

            Form_Gestion_Fourriere G_Fourriere = new Form_Gestion_Fourriere(this.getuser());
            G_Fourriere.Show();
            this.Hide();


        }

        private void btn_Gestion_Agent_Click(object sender, EventArgs e)
        {

            Form_Gestion_Agent G_Agent = new Form_Gestion_Agent(this.getuser());
            G_Agent.Show();
            this.Hide();

        }

        private void btn_Mon_Compte_Click(object sender, EventArgs e)
        {
            Form_Mon_Compte M_Compte = new Form_Mon_Compte(this.getuser());
            M_Compte.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Aff_Montant_Click(object sender, EventArgs e)
        {
            Form_Aff_Montant Montant_Fourriere = new Form_Aff_Montant(this.getuser());
            Montant_Fourriere.Show();
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
