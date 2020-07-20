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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;

            using (WSPersonasSR.WSPersonasClient client = new WSPersonasSR.WSPersonasClient())
            {
                var persona = client.obtenerPersona(identificacion);
                var nombre = persona.nombre;


            }

            //using (WSmundialSR.SOATMundialSoapClient mcli = new WSmundialSR.SOATMundialSoapClient()) {
            //    //var ja = mcli.CalcularPoliza();
            //    var jaja = mcli.expedirPolizaXML(" ");
            //}
        }
    }
}
