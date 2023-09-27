using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class MontantADO
    {

        public static void Enrg_Montant(Montant M)
        {
            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                db.Montants.Add(M);
                db.SaveChanges();
            }
        }


        public static List<Montant> GetMontant()
        {

            using (Gestion_FourriereContext db = new Gestion_FourriereContext())
            {
                var query = from m in db.Montants select m;
                return query.ToList();
            }

        }




    }
}
