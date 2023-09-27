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
    public partial class Form_Gestion_Agent : Form
    {

        public Form_Gestion_Agent(string v)
        {
            InitializeComponent();
            L_User_Connecter.Text = v;

        }

        public String getuser()
        {
            //return CIN "Login" d'utilisateur
            return L_User_Connecter.Text;
        }


        private void Form_Gestion_Agent_Load(object sender, EventArgs e)
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


            //F contient Liste de fourriere
            List<Fourriere> F = FourriereADO.GetFourriere();

            foreach (var f in F)
            {
                if ((f.Nom_Fourriere != ""))
                {
                    T_ComboBox_Nom_Fourriere.Items.Add(f.Nom_Fourriere);

                }
            }


            Remplier_dataGridView_Gestion_Agent();

        }

        private void dataGridView_Gestion_Agent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Gestion_Agent.Rows[e.RowIndex];

                T_Login_Agent.Text = row.Cells["CIN"].Value.ToString();


                string cin = row.Cells["CIN"].Value.ToString();

                //agent contient Liste de l'Agent
                List<Agent> agent = AgentADO.GetAgent();

                foreach (var A in agent)
                {
                    if ((A.Login_Agent == int.Parse(cin)))
                    {
                        T_Mdp.Text = A.Mdp;
                    }
                }


                T_Nom_Agent.Text = row.Cells["NOM"].Value.ToString();
                T_Prenom_Agent.Text = row.Cells["PRENOM"].Value.ToString();
                T_Email_Agent.Text = row.Cells["EMAIL"].Value.ToString();
                T_Num_Tel_Agent.Text = row.Cells["NUM_TEL"].Value.ToString();
                T_ComboBox_Nom_Fourriere.Text = row.Cells["NOM_FOURRIERE"].Value.ToString();

            }

        

        }

        public void Remplier_dataGridView_Gestion_Agent()
        {
            dataGridView_Gestion_Agent.DataSource = AgentADO.GetAgent().Select(ag => new { CIN = ag.Login_Agent, NOM = ag.Nom, PRENOM = ag.Prenom, EMAIL = ag.Email, NUM_TEL = ag.Num_Tel, NOM_FOURRIERE = ag.Nom_Fourriere }).ToList();

        }
        public void champs_vide()
        {
            T_Login_Agent.Clear();
            T_Mdp.Clear();
            T_Nom_Agent.Clear();
            T_Prenom_Agent.Clear();
            T_Email_Agent.Clear();
            T_Num_Tel_Agent.Clear();
            T_ComboBox_Nom_Fourriere.Text = "";

        }
        private void btn_Ajouter_Agent_Click(object sender, EventArgs e)
        {


            try
            {
                if (!(T_Login_Agent.Text.Trim().Equals("") || T_Mdp.Text.Trim().Equals("") || T_Nom_Agent.Text.Trim().Equals("") || T_Prenom_Agent.Text.Trim().Equals("") || T_Email_Agent.Text.Trim().Equals("") || T_Num_Tel_Agent.Text.Trim().Equals("") || T_ComboBox_Nom_Fourriere.Text.Trim().Equals("")))
                {

                    Agent a = new Agent();

                    a.Login_Agent = int.Parse(T_Login_Agent.Text);
                    a.Mdp = T_Mdp.Text;
                    a.Nom = T_Nom_Agent.Text;
                    a.Prenom = T_Prenom_Agent.Text;
                    a.Email = T_Email_Agent.Text;
                    a.Num_Tel = T_Num_Tel_Agent.Text;
                    a.Nom_Fourriere = T_ComboBox_Nom_Fourriere.Text;
                    a.Login_Admin = int.Parse(L_User_Connecter.Text);
                    AgentADO.Ajouter_Agent(a);

                    MessageBox.Show("Agent enregistrer avec succées");
                    Remplier_dataGridView_Gestion_Agent();

                    //Videer les champs
                    champs_vide();
                }
                else
                {
                    MessageBox.Show("Verifier votre champs vide");
                }
            }
            catch
            {
                // 
                L_erreur_Fourriere.Text = "Agent déja existe , vérifier votre données";
            }

        }

        private void btn_Modifier_Agent_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(T_Login_Agent.Text.Trim().Equals("") || T_Mdp.Text.Trim().Equals("") || T_Nom_Agent.Text.Trim().Equals("") || T_Prenom_Agent.Text.Trim().Equals("") || T_Email_Agent.Text.Trim().Equals("") || T_Num_Tel_Agent.Text.Trim().Equals("") || T_ComboBox_Nom_Fourriere.Text.Trim().Equals("")))
                {

                    Agent A = new Agent();
                    int CIN_a = int.Parse(T_Login_Agent.Text);
                    String mdp = T_Mdp.Text;
                    String nom = T_Nom_Agent.Text;
                    String prenom = T_Prenom_Agent.Text;
                    String email = T_Email_Agent.Text;
                    String num_tel = T_Num_Tel_Agent.Text;
                    String nom_fourrier = T_ComboBox_Nom_Fourriere.Text;

                    A.Login_Agent = CIN_a;
                    A.Mdp = mdp;
                    A.Nom = nom;
                    A.Prenom = prenom;
                    A.Email = email;
                    A.Num_Tel = num_tel;
                    A.Nom_Fourriere = nom_fourrier;
                    A.Login_Admin = int.Parse(L_User_Connecter.Text);

                    AgentADO.Modifier_Agent(A);
                    MessageBox.Show("Agent Modifier avec succées");

                    Remplier_dataGridView_Gestion_Agent();
                    champs_vide();
                    

                }
                else
                {
                    MessageBox.Show("verifier votre champs vide");
                }

            }
            catch
            {
                //MessageBox.Show("Fourriere n'existe pas , verifier votre données");
                L_erreur_Fourriere.Text = "Fourriere n'existe pas , verifier votre données";
            }



        }

        private void btn_Supprimer_Agent_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(T_Login_Agent.Text.Trim().Equals("")))
                {

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Vous voulez supprimer ?", " ", buttons);
                    if (result == DialogResult.Yes)
                    {

                        AgentADO.Supprimer_Agent(int.Parse(T_Login_Agent.Text));
                        MessageBox.Show("Agent supprimer avec succées");

                    }
                    else
                    {
                        return;
                    }

                    Remplier_dataGridView_Gestion_Agent();
                    champs_vide();

                }
                else
                {
                    MessageBox.Show("champs CIN d'Agent est vide ");
                }
            }
            catch
            {
                //
                L_erreur_Fourriere.Text = "Agent n'existe pas , verifier votre données";
            }
        }

        private void btn_icon_home_Click(object sender, EventArgs e)
        {
            Dashboard_Admin D_Admin = new Dashboard_Admin(this.getuser());
            D_Admin.Show();
            this.Hide();
        }

        private void btn_icon_clear_Click(object sender, EventArgs e)
        {
            champs_vide();
        }

        private void btn_icon_recherche_Click(object sender, EventArgs e)
        {

            if (!(T_CIN_Agent_Rech.Text.Trim().Equals("")))
            {


                //db = new Gestion_FourriereContext();
                int CIN_a = int.Parse(T_CIN_Agent_Rech.Text);

                //dataGridView_Gestion_Agent.DataSource = db.Agents.Where(ag => ag.Login_Agent == CIN_a).Select(a => new { CIN = a.Login_Agent, NOM = a.Nom, PRENOM = a.Prenom, EMAIL = a.Email, NUM_TEL = a.Num_Tel, NOM_FOURRIERE = a.Nom_Fourriere }).ToList();

                List<Agent> agent = AgentADO.GetAgent();

                foreach (var A in agent)
                {
                    if (A.Login_Agent == CIN_a)
                    {
                        dataGridView_Gestion_Agent.DataSource = agent.Where(ag => ag.Login_Agent == CIN_a).Select(a => new { CIN = a.Login_Agent, NOM = a.Nom, PRENOM = a.Prenom, EMAIL = a.Email, NUM_TEL = a.Num_Tel, NOM_FOURRIERE = a.Nom_Fourriere }).ToList();

                    }
                }


            }
            else
            {
                MessageBox.Show("CIN d'Agent est vide verifier votre chmps");
            }
        }

        private void btn_icon_supp_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(T_CIN_Agent_Rech.Text.Trim().Equals("")))
                {

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Vous voulez supprimer ?", " ", buttons);
                    if (result == DialogResult.Yes)
                    {

                        AgentADO.Supprimer_Agent(int.Parse(T_CIN_Agent_Rech.Text));
                        MessageBox.Show("Agent supprimer avec succées");
                    }
                    else
                    {
                        return;
                    }

                    Remplier_dataGridView_Gestion_Agent();
                    champs_vide();
                    T_CIN_Agent_Rech.Clear();
                    

                }
                else
                {
                    MessageBox.Show("champs CIN d'Agent est vide ");
                }
            }
            catch
            {
                //
                L_erreur_Fourriere.Text = "Agent n'existe pas , verifier votre données";
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
