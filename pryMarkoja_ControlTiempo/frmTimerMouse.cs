using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarkoja_ControlTiempo
{
    public partial class frmTimerMouse : Form
    {
        int iTiempo = 0;

        public frmTimerMouse()
        {
            InitializeComponent();
        }

        private void pTrabajo_MouseMove(object sender, MouseEventArgs e)
        {
            timerTiempoAplicacion.Start();
            lblCoordenadas.Text = e.Location.ToString();
            //aca va el stream Writer, pero con base de datos.
        }

        private void pTrabajo_MouseLeave(object sender, EventArgs e)
        {
            timerTiempoAplicacion.Stop();
        }

        private void timerTiempoAplicacion_Tick(object sender, EventArgs e)
        {
            iTiempo++;
            lblTiempoContador.Text = iTiempo.ToString();
        }

        private void btnAuditar_Click(object sender, EventArgs e)
        {
            lstCoordenadas.Visible = true;
        }

        private void frmTimerMouse_Load(object sender, EventArgs e)
        {
            lstCoordenadas.Visible = false;
        }
    }
}
