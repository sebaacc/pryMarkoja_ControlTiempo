namespace pryMarkoja_ControlTiempo
{
    partial class frmTimerMouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pTrabajo = new System.Windows.Forms.Panel();
            this.lstCoordenadas = new System.Windows.Forms.ListBox();
            this.btnAuditar = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTiempoContador = new System.Windows.Forms.Label();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.lblLugares = new System.Windows.Forms.Label();
            this.timerTiempoAplicacion = new System.Windows.Forms.Timer(this.components);
            this.pTrabajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTrabajo
            // 
            this.pTrabajo.Controls.Add(this.lstCoordenadas);
            this.pTrabajo.Location = new System.Drawing.Point(114, 60);
            this.pTrabajo.Name = "pTrabajo";
            this.pTrabajo.Size = new System.Drawing.Size(365, 275);
            this.pTrabajo.TabIndex = 0;
            this.pTrabajo.MouseLeave += new System.EventHandler(this.pTrabajo_MouseLeave);
            this.pTrabajo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTrabajo_MouseMove);
            // 
            // lstCoordenadas
            // 
            this.lstCoordenadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCoordenadas.FormattingEnabled = true;
            this.lstCoordenadas.Location = new System.Drawing.Point(0, 0);
            this.lstCoordenadas.Name = "lstCoordenadas";
            this.lstCoordenadas.Size = new System.Drawing.Size(365, 275);
            this.lstCoordenadas.TabIndex = 1;
            // 
            // btnAuditar
            // 
            this.btnAuditar.Location = new System.Drawing.Point(656, 384);
            this.btnAuditar.Name = "btnAuditar";
            this.btnAuditar.Size = new System.Drawing.Size(75, 23);
            this.btnAuditar.TabIndex = 2;
            this.btnAuditar.Text = "Auditar";
            this.btnAuditar.UseVisualStyleBackColor = true;
            this.btnAuditar.Click += new System.EventHandler(this.btnAuditar_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(111, 356);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(92, 13);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "Tiempo de trabajo";
            // 
            // lblTiempoContador
            // 
            this.lblTiempoContador.AutoSize = true;
            this.lblTiempoContador.Location = new System.Drawing.Point(221, 356);
            this.lblTiempoContador.Name = "lblTiempoContador";
            this.lblTiempoContador.Size = new System.Drawing.Size(10, 13);
            this.lblTiempoContador.TabIndex = 4;
            this.lblTiempoContador.Text = "-";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(221, 394);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(10, 13);
            this.lblCoordenadas.TabIndex = 6;
            this.lblCoordenadas.Text = "-";
            // 
            // lblLugares
            // 
            this.lblLugares.AutoSize = true;
            this.lblLugares.Location = new System.Drawing.Point(111, 394);
            this.lblLugares.Name = "lblLugares";
            this.lblLugares.Size = new System.Drawing.Size(45, 13);
            this.lblLugares.TabIndex = 5;
            this.lblLugares.Text = "Lugares";
            // 
            // timerTiempoAplicacion
            // 
            this.timerTiempoAplicacion.Interval = 1000;
            this.timerTiempoAplicacion.Tick += new System.EventHandler(this.timerTiempoAplicacion_Tick);
            // 
            // frmTimerMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.lblLugares);
            this.Controls.Add(this.lblTiempoContador);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnAuditar);
            this.Controls.Add(this.pTrabajo);
            this.Name = "frmTimerMouse";
            this.Text = "frmTimerMouse";
            this.Load += new System.EventHandler(this.frmTimerMouse_Load);
            this.pTrabajo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTrabajo;
        private System.Windows.Forms.ListBox lstCoordenadas;
        private System.Windows.Forms.Button btnAuditar;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTiempoContador;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.Label lblLugares;
        private System.Windows.Forms.Timer timerTiempoAplicacion;
    }
}