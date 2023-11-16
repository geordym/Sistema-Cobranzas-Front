using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Sistema_Cobranza.Modelo
{
    class Usuario
    {
        public int id;
        private string nombre;
        private string correo;
        private string clave;
        private string rol;

        public Usuario()
        {
            this.Id = 0;
            this.Nombre = "";
            this.Correo = "";
            this.Clave = "";
            this.Rol = "";
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Rol { get => rol; set => rol = value; }

    }
}
