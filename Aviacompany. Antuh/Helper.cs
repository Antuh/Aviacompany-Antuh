using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aviacompany.Antuh.Model;
using System.Threading.Tasks;

namespace Aviacompany.Antuh.Model
{
    class Helper
    {
        private static Model.Entities1 s_entities;
        public static Model.Entities1 getContext()
        {
            if (s_entities == null)
            {
                s_entities = new Model.Entities1();
            }
            return s_entities;
        }

        public static void Create(Model.Client client, Passport passport, Visa visa)
        {
            s_entities.Client.Add(client);
            s_entities.Passport.Add(passport);
            s_entities.Visa.Add(visa);
            s_entities.SaveChanges();
        }


        public static int GetLastIDclient()
        {
            int id = s_entities.Client.OrderByDescending(client => client.ID_Client).First().ID_Client;
            return id + 1;
        }

        public static int GetLastIDPassport()
        {
            int id = s_entities.Passport.OrderByDescending(passport => passport.ID_Passport).First().ID_Passport;
            return id + 1;
        }
        public static int GetLastIDVisa()
        {
            int id = s_entities.Visa.OrderByDescending(visa => visa.ID_Visa).First().ID_Visa;
            return id + 1;
        }

        public static int GetLastIDAuth()
        {
            int id = s_entities.Authorization.OrderByDescending(authorizations => authorizations.ID_Authorization).First().ID_Authorization;
            return id + 1;
        }
    }
}
