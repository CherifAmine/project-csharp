using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class Form_Authentification : Form
    {
        public Form_Authentification()
        {
            InitializeComponent();
        }

        private Gestion_FourriereContext db;


        public String getuser()
        {
            //return CIN "Login" d'utilisateur
            return T_Login.Text;
        }

        bool test = false;
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            String Login = T_Login.Text;
            String Mdp = T_Mdp.Text;

            if (CompteADO.TestCompteAdmin(Login, Mdp))

            {
                //MessageBox.Show(" existe");
               // MessageBox.Show(Login + " " + Mdp);
                Dashboard_Admin dashboard = new Dashboard_Admin(this.getuser());
                dashboard.Show();
                this.Hide();
                test = true;
            }
            if(CompteADO.TestCompteAgent(Login, Mdp))
            {
               // MessageBox.Show(" existe agent");
               // MessageBox.Show(Login + " " + Mdp);
                Dashboard_Agent dashboard = new Dashboard_Agent(this.getuser());
                dashboard.Show();
                this.Hide();
                test = true;

            }

            if(test==false)
            {
                MessageBox.Show("n'existe pas");
            }

        }

        private void Form_Authentification_Load(object sender, EventArgs e)
        {
          

        }
    }
}
