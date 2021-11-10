using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_task1.Models
{
    public class Oglasavanje
    {
      
        public static void AddOglas(Automobil automobil)
        {
            if (automobil != null)
            {
                mvc_task1Context dataContext = new mvc_task1Context();
                dataContext.Automobil.Add(automobil);
                dataContext.SaveChanges();
            }
        }

        public static void UpdateOglas(Automobil automobil, int id)
        {
            if (automobil != null && id != default (int))
            {
                mvc_task1Context dataContext = new mvc_task1Context();
                var dbauto = dataContext.Automobil.SingleOrDefault(auto => auto.Id == id);
                dbauto.Cena = automobil.Cena;
                dbauto.Opis = automobil.Opis;
                dbauto.Kontakt = automobil.Kontakt;
                dbauto.Marka = automobil.Marka;
                dbauto.Model = automobil.Model;
                dbauto.Snaga = automobil.Snaga;
                dbauto.Karoserija = automobil.Karoserija;
                dbauto.Gorivo = automobil.Gorivo;
                dbauto.Godiste = automobil.Godiste;
                if (automobil.Foto != null)
                    dbauto.Foto = automobil.Foto;
                dbauto.ZapreminaMotora = automobil.ZapreminaMotora;

                dataContext.SaveChanges();
            }
        }

        public static List<Automobil> GetOglas()
        {
            mvc_task1Context dataContext = new mvc_task1Context();
            return dataContext.Automobil.ToList();

        }

        public static Automobil GetAutomobil(int id)
        {
           mvc_task1Context dataContext = new mvc_task1Context();
           return dataContext.Automobil.SingleOrDefault(auto => auto.Id == id);
            

        }

        public static Automobil DeleteAutomobil(int id)
        {
            mvc_task1Context dataContext = new mvc_task1Context();

            var dbAuto =  dataContext.Automobil.SingleOrDefault(auto => auto.Id == id);
            if (dbAuto != null)
            {
                dataContext.Automobil.Remove(dbAuto);
                dataContext.SaveChanges();
            }
            return dbAuto;
        }
    }
}
