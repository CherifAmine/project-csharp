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
    public partial class Form_Mon_Compte : Form
    {

        public Form_Mon_Compte(string v)
        {
            InitializeComponent();
            L_User_Connecter.Text = v;

        }

        public String getuser()
        {
            //return CIN "Login" d'utilisateur
            return L_User_Connecter.Text;
        }


        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(T_Mdp.Text.Trim().Equals("") || T_Nom_Admin.Text.Trim().Equals("") || T_Prenom_Admin.Text.Trim().Equals("") || T_Email_Admin.Text.Trim().Equals("") || T_Num_Tel_Admin.Text.Trim().Equals("")))
                {


                    int CIN_a = int.Parse(this.getuser());
                    String mdp = T_Mdp.Text;
                    String nom = T_Nom_Admin.Text;
                    String prenom = T_Prenom_Admin.Text;
                    String email = T_Email_Admin.Text;
                    String num_tel = T_Num_Tel_Admin.Text;

                    List<Administrateur> Admin = AdministrateurADO.Get_Informations_Admin();
                    foreach (var A in Admin)
                    {
                        if ((A.Login_Admin == int.Parse(L_User_Connecter.Text)))
                        {
                            A.Mdp = mdp;
                            A.Nom = nom;
                            A.Prenom = prenom;
                            A.Email = email;
                            A.Num_Tel = num_tel;

                            AdministrateurADO.Modifier_Admin(A);
                            MessageBox.Show("Administrateur modifier avec Succées");

                        }

                    }
                    get_information();
                    L_erreur_Fourriere.Text = "";
                }
                else
                {

                    MessageBox.Show("Verifier votre champs vide");
                }
            }
            catch
            {
                MessageBox.Show("Administrateur n'existe pas , verifier votre données");
                //L_erreur_Fourriere.Text = "Administrateur n'existe pas , verifier votre données";
            }

        }


        public void get_information()
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

                    T_Mdp.Text = A.Mdp;
                    T_Nom_Admin.Text = A.Nom;
                    T_Prenom_Admin.Text = A.Prenom;
                    T_Email_Admin.Text = A.Email;
                    T_Num_Tel_Admin.Text = A.Num_Tel;
                }

            }


        }
        private void Form_Mon_Compte_Load(object sender, EventArgs e)
        {
            get_information();
        }

        private void btn_icon_clear_Click(object sender, EventArgs e)
        {
            T_Mdp.Clear();
            T_Nom_Admin.Clear();
            T_Prenom_Admin.Clear();
            T_Email_Admin.Clear();
            T_Num_Tel_Admin.Clear();
        }

        private void btn_icon_home_Click(object sender, EventArgs e)
        {
            Dashboard_Admin D_Admin = new Dashboard_Admin(this.getuser());
            D_Admin.Show();
            this.Hide();
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

        private void btn_Montant_Click(object sender, EventArgs e)
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