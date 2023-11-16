using Sistema_Cobranza.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cobranza.Formularios
{
    public partial class FrmLogin : Form

    {
        private UsuarioService usuarioService = new UsuarioService();

        public FrmLogin()
        {
            InitializeComponent();

            usuarioService.Login();

        }


       
    }
}
