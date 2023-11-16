using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cobranza.Modelo
{
    class Payment
    {
        private int id;
        private int bill_id;
        private int client_id;
        private double amount;
        private DateTime paid_at;
        private string payment_method;
        private string status;
        private string notes;


        private Bill bill;
        private Client client;

    }


}
