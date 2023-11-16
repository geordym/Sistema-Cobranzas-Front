using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cobranza.Modelo
{
     class Suscription
    {
        private int id { get; set; }
        private int plan_id { get; set; }
        private int client_id { get; set; }

        private double cost { get; set; }
        private DateTime start_date { get; set; }
        private bool status { get; set; }

        private Plan plan { get; set; }
        private Client client { get; set; }

    }
}
