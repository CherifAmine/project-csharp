using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Controller
{
    public class FourriereADO
    {

        public static void Ajouter_Fourriere(Fourriere f)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                db.Fourrieres.Add(f);
                db.SaveChanges();
            }
        }


        public static void Supprimer_Fourriere(int id)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {

                //methode1
              //  Fourriere fou = db.Fourrieres.Where(f => f.Id_Fourriere == id_f).First();
              //  db.Fourrieres.Remove(fou);
              //  db.SaveChanges();

                //methode 2
                Fourriere f = db.Fourrieres.Find(id);
                if (f != null)
                {
                    try
                    {
                        db.Fourrieres.Remove(f);
                        db.SaveChanges();
                    }

                    catch
                    {
                       
                        //

                    }
                }

            }
        }


        public static void Modifier_Fourriere(int id,string nom_f,int cin_admin)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                     
                Fourriere fourriere = db.Fourrieres.Where(f => f.Id_Fourriere == id).First();
                fourriere.Nom_Fourriere = nom_f;
                fourriere.Login_Admin = cin_admin;
                db.SaveChanges();


            }
        }



        public static List<Fourriere> GetFourriere()
        {

            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                var query = from f in db.Fourrieres select f;
                return query.ToList();
            }

        }


    public static bool Fourriere_Exixte(string id)
        {
            using (Gestion_FourriereContext context = new Gestion_FourriereContext())
            {
                Fourriere f = context.Fourrieres.Find(id);
                if (f != null)
                    return true;
                return false;


            }
        }




    }
}
