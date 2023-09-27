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
    public partial class Form_Mon_Compte_Agent : Form
    {
        public Form_Mon_Compte_Agent(string v)
        {
            InitializeComponent();
            L_User_Connecter.Text = v;
        }

        public String getuser()
        {
            //return CIN "Login" d'utilisateur
            return L_User_Connecter.Text;
        }


        private void Form_Mon_Compte_Agent_Load(object sender, EventArgs e)
        {
            get_information();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(T_Mdp.Text.Trim().Equals("") || T_Nom_Agent.Text.Trim().Equals("") || T_Prenom_Agent.Text.Trim().Equals("") || T_Email_Agent.Text.Trim().Equals("") || T_Num_Tel_Agent.Text.Trim().Equals("")))
                {


                    int CIN_a = int.Parse(this.getuser());
                    String mdp = T_Mdp.Text;
                    String nom = T_Nom_Agent.Text;
                    String prenom = T_Prenom_Agent.Text;
                    String email = T_Email_Agent.Text;
                    String num_tel = T_Num_Tel_Agent.Text;

                    List<Agent> Agent = AgentADO.GetAgent();
                    foreach (var A in Agent)
                    {
                        if ((A.Login_Agent == int.Parse(L_User_Connecter.Text)))
                        {
                            A.Mdp = mdp;
                            A.Nom = nom;
                            A.Prenom = prenom;
                            A.Email = email;
                            A.Num_Tel = num_tel;

                            AgentADO.Modifier_Agent(A);
                            MessageBox.Show("Agent modifier avec Succées");

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
                MessageBox.Show("Agent n'existe pas , verifier votre données");
                //L_erreur_Fourriere.Text = "Agent n'existe pas , verifier votre données";
            }

        }



        public void get_information()
        {


            //Agent contient Liste de l'administrateur
            List<Agent> Agent = AgentADO.GetAgent();
            foreach (var A in Agent)
            {
                if ((A.Login_Agent == int.Parse(L_User_Connecter.Text)))
                {
                    L_Nom_User.Text = A.Nom;
                    L_Prenom_User.Text = A.Prenom;
                    L_Email_User.Text = A.Email;

                    T_Mdp.Text = A.Mdp;
                    T_Nom_Agent.Text = A.Nom;
                    T_Prenom_Agent.Text = A.Prenom;
                    T_Email_Agent.Text = A.Email;
                    T_Num_Tel_Agent.Text = A.Num_Tel;
                }

            }


        }

        private void btn_icon_clear_Click(object sender, EventArgs e)
        {
            T_Mdp.Clear();
            T_Nom_Agent.Clear();
            T_Prenom_Agent.Clear();
            T_Email_Agent.Clear();
            T_Num_Tel_Agent.Clear();
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

        private void btn_Montant_Click(object sender, EventArgs e)
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
