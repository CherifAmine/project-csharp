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
    public partial class Form_Gestion_Fourriere : Form
    {
     
        public Form_Gestion_Fourriere(string v)
        {
            InitializeComponent();
            L_User_Connecter.Text = v;

        }

        public String getuser()
        {
            //return CIN "Login" d'utilisateur
            return L_User_Connecter.Text;
        }



        private void btn_Ajouter_Fourriere_Click(object sender, EventArgs e)
        {


            try
            {
                if (!(T_Id_Fourriere.Text.Trim().Equals("") || T_Nom_Fourriere.Text.Trim().Equals("")))
                {

                    
                    Fourriere fourriere = new Fourriere();
                    fourriere.Id_Fourriere = int.Parse(T_Id_Fourriere.Text);
                    fourriere.Nom_Fourriere = T_Nom_Fourriere.Text;
                    fourriere.Login_Admin = int.Parse(L_User_Connecter.Text);

                    FourriereADO.Ajouter_Fourriere(fourriere);
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
                L_erreur_Fourriere.Text = "Fourriere déja existe , vérifier votre données";
            }


        }


        public void vide_champs()
        {
            //Videer les champs
            L_erreur_Fourriere.Text = "";
            T_Id_Fourriere.Clear();
            T_Nom_Fourriere.Clear();

        }

        public void Remplir_dataGridView_Gestion_Fourriere()
        {
            List<Fourriere> fourriere = FourriereADO.GetFourriere();
            dataGridView_Gestion_Fourriere.DataSource = fourriere.Select(f => new { ID_FOURRIERE = f.Id_Fourriere, NOM_FOURRIERE = f.Nom_Fourriere }).ToList();

        }



        private void Form_Gestion_Fourriere_Load(object sender, EventArgs e)
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

            Remplir_dataGridView_Gestion_Fourriere();
        }

        private void btn_Modifier_Fourriere_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(T_Id_Fourriere.Text.Trim().Equals("") || T_Nom_Fourriere.Text.Trim().Equals("")))
                {

                    Fourriere f = new Fourriere();
                    int IdFourriere = int.Parse(T_Id_Fourriere.Text);
                    string NomFourriere = T_Nom_Fourriere.Text;
                    int LoginAdmin = int.Parse(L_User_Connecter.Text);

                    FourriereADO.Modifier_Fourriere(IdFourriere, NomFourriere,LoginAdmin);
                    MessageBox.Show("Fourriere modifier avec Succées");

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
                MessageBox.Show("Fourriere n'existe pas , verifier votre données");
                //L_erreur_Fourriere.Text = "Fourriere n'existe pas , verifier votre données";
            }

        }

        private void btn_Supprimer_Fourriere_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(T_Id_Fourriere.Text.Trim().Equals("")))
                {
                  
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Vous voulez supprimer ?"," ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        
                        FourriereADO.Supprimer_Fourriere(int.Parse(T_Id_Fourriere.Text));
                        MessageBox.Show("Fourriere Supprimer avec Succées");

                    }
                    else
                    {
                        return;
                    }

                    Remplir_dataGridView_Gestion_Fourriere();
                    vide_champs();

                }else
                {
                    MessageBox.Show("champs Id de fourriere est vide ");
                }
                } catch{

                MessageBox.Show("Fourriere n'existe pas , verifier votre données");

                //L_erreur_Fourriere.Text = "Fourriere n'existe pas , verifier votre données";
            }
        }

        private void dataGridView_Gestion_Fourriere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView_Gestion_Fourriere.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                T_Id_Fourriere.Text = row.Cells[0].Value.ToString();
                T_Nom_Fourriere.Text = row.Cells[1].Value.ToString();

            }

        }

        private void btn_icon_clear_Click(object sender, EventArgs e)
        {
            T_Id_Fourriere.Clear();
            T_Nom_Fourriere.Clear();
        }

        private void btn_icon_home_Click(object sender, EventArgs e)
        {
            Dashboard_Admin D_Admin = new Dashboard_Admin(this.getuser());
            D_Admin.Show();
            this.Hide();
        }



       

        


    //Button Gestion de Fourriere si on click sur ce button il navigate vers la form Gestion de fourriere
         private void btn_Gestion_Fourriere_Click_1(object sender, EventArgs e)
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
