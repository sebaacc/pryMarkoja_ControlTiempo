using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarkoja_ControlTiempo
{
    public partial class frmLogin : Form
    {
        int iTiempo = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tTiempoAplicacion_Tick(object sender, EventArgs e)
        {
            
            //string tiempoFormateado = string.Format("{0:00}:{1:00}:{2:00}",
            //    tiempoTranscurrido.Hours, tiempoTranscurrido.Minutes, tiempoTranscurrido.Seconds);

            iTiempo++;
            lblTiempoContador.Text = iTiempo.ToString();
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            activarCronometro();
        }

        private void activarCronometro()
        {
            if (btnTrabajo.Text == "Trabajo")
            {
                timerTiempoAplicacion.Start();
                btnTrabajo.Text = "Finalizar"; 
                btnTrabajo.BackColor = Color.Honeydew;
            }
            else
            {
                timerTiempoAplicacion.Stop();
                btnTrabajo.Text = "Trabajo";
            }

        }
    }
}
