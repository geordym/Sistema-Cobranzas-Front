using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cobranza.Modelo
{
    class Bill
    {

        private int id { get; set; }
        private int client_id { get; set; }
        private DateTime date { get; set; }
        private string status { get; set; }
        private double total { get; set; }
        private Client client { get; set; }

        private List<ItemBill> items { get; set; }



    }
}
