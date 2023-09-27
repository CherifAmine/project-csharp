using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Controller
{
    public class CompteADO
    {

        public static bool TestCompteAdmin(string Login, string Mdp)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {

                var query = from a in db.Administrateurs select a;
                var Admin = query.ToList();

                bool test = false;

                foreach (var A in Admin)
                {
                    if ((int.Parse(Login) == A.Login_Admin) && (Mdp == A.Mdp))
                    {
                        test = true;
                        break;
                    }
                }


                var query2 = from a in db.Agents select a;
                var Ag = query2.ToList();

                foreach (var A in Ag)
                {
                    if ((int.Parse(Login) == A.Login_Admin) && (Mdp == A.Mdp))
                    {
                        test = true;
                        break;
                    }
                }


                //return résultat
                if (test)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
        public static bool TestCompteAgent(string Login, string Mdp)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {

                bool test = false;
                var query2 = from a in db.Agents select a;
                var Ag = query2.ToList();

                foreach (var A in Ag)
                {
                    if ((int.Parse(Login) == A.Login_Agent) && (Mdp == A.Mdp))
                    {
                        test = true;
                        break;
                    }
                }


                //return résultat
                if (test)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }


    }

}
