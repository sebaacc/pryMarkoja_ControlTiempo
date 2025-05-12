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
        private System.Diagnostics.Stopwatch miCronometro = new System.Diagnostics.Stopwatch();
        private bool cronometroActivo = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tTiempoAplicacion_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = miCronometro.Elapsed;
            string tiempoFormateado = string.Format("{0:00}:{1:00}:{2:00}",
                tiempoTranscurrido.Hours, tiempoTranscurrido.Minutes, tiempoTranscurrido.Seconds);
            lblTiempoStatus.Text = tiempoFormateado;
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            activarCronometro();
        }

        private void activarCronometro()
        {
            if (cronometroActivo == false)
            {
                cronometroActivo = true;
                tTiempoAplicacion.Start();
                btnTrabajo.Text = "Finalizar";
            } else
            {
                cronometroActivo = false;
                tTiempoAplicacion.Start();
                btnTrabajo.Text = "Trabajo";
            }
        }
    }
}
