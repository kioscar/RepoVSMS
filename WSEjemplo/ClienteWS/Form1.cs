using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;

            using(WSPersona.WSPersonasClient cliente = new WSPersona.WSPersonasClient())
            {
                var persona = cliente.ObtenerPersona(id);

                if (persona.Nombre != null)
                    lblEdad.Text = persona.Nombre;
                else
                    lblEdad.Text = persona.Error;
                lblNombre.Text = persona.Edad.ToString(); 
            }
        }
    }
}
