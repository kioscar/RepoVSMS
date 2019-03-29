using System;
using System.Windows.Forms;
using CilenteWEBS.WSPersonas;
using CilenteWEBS.SATService;

namespace CilenteWEBS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;

            WSPersonasClient client = new WSPersonasClient();
            ConsultaCFDIServiceClient cliente = new ConsultaCFDIServiceClient("BasicHttpBinding_IConsultaCFDIService");

            var acuse = cliente.Consulta("?re=[RFC_Emisor]&rr=[RFC_Receptor]&tt=[Total]&id=[UUID]");


            lblError.Text = acuse.CodigoEstatus;
            lblNombre.Text = acuse.Estado;

            /*var persona = client.ObtenerPersona(id);

            lblNombre.Text = persona.Nombre;
            lblEdad.Text = persona.Edad.ToString();
            lblError.Text = persona.Error;*/
            
            
        }
    }
}
