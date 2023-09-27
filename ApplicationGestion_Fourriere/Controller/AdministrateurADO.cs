using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class AdministrateurADO
    {


        public static List<Administrateur> Get_Informations_Admin()
        {

            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {



              //  Administrateur admin = db.Administrateurs.Where(a => a.Login_Admin == int.Parse(Login)).First();

                var query = from f in db.Administrateurs  select f;
                return query.ToList();
                

            }

        }



        public static void Modifier_Admin(Administrateur A)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                Administrateur ag = db.Administrateurs.Find(A.Login_Admin);
                if (ag != null)
                {
                    ag.Mdp = A.Mdp;
                    ag.Nom = A.Nom;
                    ag.Prenom = A.Prenom;
                    ag.Email = A.Email;
                    ag.Num_Tel = A.Num_Tel;
                    db.SaveChanges();

                }
            }
        }





    }
}
