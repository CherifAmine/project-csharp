using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class AgentADO
    {


        public static void Ajouter_Agent(Agent A)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                db.Agents.Add(A);
                db.SaveChanges();
            }
        }


        public static void Supprimer_Agent(int CIN_Agent)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {

                //methode1
                //  Fourriere fou = db.Fourrieres.Where(f => f.Id_Fourriere == id_f).First();
                //  db.Fourrieres.Remove(fou);
                //  db.SaveChanges();

                //methode 2
                try
                {
                    Agent a = db.Agents.Find(CIN_Agent);
                    if (a != null)
                    {

                        db.Agents.Remove(a);
                        db.SaveChanges();

                    }

                }catch{
                    //
                }
                }

            }
        

    public static void Modifier_Agent(Agent A)
    {
        using (Gestion_FourriereContext db = new Gestion_FourriereContext())
        {
            Agent ag = db.Agents.Find(A.Login_Agent);
            if (ag != null)
            {
                ag.Mdp = A.Mdp;
                ag.Nom = A.Nom;
                ag.Prenom = A.Prenom;
                ag.Email = A.Email;
                ag.Num_Tel = A.Num_Tel;
                ag.Login_Admin = A.Login_Admin;
                db.SaveChanges();

            }
        }
    }


    public static List<Agent> GetAgent()
        {

            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                var query = from a in db.Agents select a;
                return query.ToList();
            }

        }

        public static bool Agent_Exixte(string CIN_Agent)
        {
            using (Gestion_FourriereContext context = new Gestion_FourriereContext())
            {
                Fourriere a = context.Fourrieres.Find(CIN_Agent);
                if (a != null)
                    return true;
                return false;


            }
        }






    }
}
