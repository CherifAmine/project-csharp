using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class VehiculeADO
    {


        public static List<Vehicule> GetVehicule()
        {

            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                var query = from v in db.Vehicules select v;
                return query.ToList();
            }

        }


        public static void Ajouter_Vehicule(Vehicule v)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                db.Vehicules.Add(v);
                db.SaveChanges();

            }
        }


        public static void Supprimer_Vehicule(string immatricule)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {

                string I = immatricule;
                Vehicule vehicule = db.Vehicules.Where(v => v.Immatriculation == immatricule).First();

                db.Vehicules.Remove(vehicule);
                db.SaveChanges();

            }

        }



        public static void Modifier_vehicule(string imm, string marque_v)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {

                var query = from v in db.Vehicules select v;
                var VEHICULE = query.ToList();

                foreach (var V in VEHICULE)
                {
                    if ((V.Immatriculation == imm && V.Date_Sortiee == null))
                    {
                        V.Marque = marque_v;
                        db.SaveChanges();

                    }
                }

            }

        }


        public static void Modifier_vehicule_Sortie(string imm, string Cart_Crise, string Nom_Prop_vehicule, string CIN_Conducteur_Vehicule, string Prix, string Date_Sortie)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {

                var query = from v in db.Vehicules select v;
                var VEHICULE = query.ToList();

                foreach (var V in VEHICULE)
                {
                    if ((V.Immatriculation == imm && V.Date_Sortiee == null))
                    {
                        V.Num_carte_grise = Cart_Crise;
                        V.Nom_Prenom_Proprietaire = Nom_Prop_vehicule;
                        V.CIN_Conducteur = int.Parse(CIN_Conducteur_Vehicule);
                        V.Prix = float.Parse(Prix);
                        V.Date_Sortiee= DateTime.Now.Date;
                        db.SaveChanges();

                    }
                }

            }


        }
    }
}
