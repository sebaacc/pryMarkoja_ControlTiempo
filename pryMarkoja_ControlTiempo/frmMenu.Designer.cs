namespace pryMarkoja_ControlTiempo
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sBarraInferior = new System.Windows.Forms.StatusStrip();
            this.lblTiempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerTiempoAplicacion = new System.Windows.Forms.Timer(this.components);
            this.btnTrabajo = new System.Windows.Forms.Button();
            this.lblTiempoContador = new System.Windows.Forms.Label();
            this.sBarraInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // sBarraInferior
            // 
            this.sBarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTiempo});
            this.sBarraInferior.Location = new System.Drawing.Point(0, 428);
            this.sBarraInferior.Name = "sBarraInferior";
            this.sBarraInferior.Size = new System.Drawing.Size(800, 22);
            this.sBarraInferior.TabIndex = 0;
            this.sBarraInferior.Text = "statusStrip1";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(114, 17);
            this.lblTiempo.Text = "Tiempo transcurrido";
            // 
            // timerTiempoAplicacion
            // 
            this.timerTiempoAplicacion.Tick += new System.EventHandler(this.tTiempoAplicacion_Tick);
            // 
            // btnTrabajo
            // 
            this.btnTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajo.Location = new System.Drawing.Point(238, 176);
            this.btnTrabajo.Name = "btnTrabajo";
            this.btnTrabajo.Size = new System.Drawing.Size(297, 60);
            this.btnTrabajo.TabIndex = 1;
            this.btnTrabajo.Text = "Trabajo";
            this.btnTrabajo.UseVisualStyleBackColor = true;
            this.btnTrabajo.Click += new System.EventHandler(this.btnTrabajo_Click);
            // 
            // lblTiempoContador
            // 
            this.lblTiempoContador.AutoSize = true;
            this.lblTiempoContador.Location = new System.Drawing.Point(235, 283);
            this.lblTiempoContador.Name = "lblTiempoContador";
            this.lblTiempoContador.Size = new System.Drawing.Size(10, 13);
            this.lblTiempoContador.TabIndex = 2;
            this.lblTiempoContador.Text = "-";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTiempoContador);
            this.Controls.Add(this.btnTrabajo);
            this.Controls.Add(this.sBarraInferior);
            this.Name = "frmLogin";
            this.Text = "Inicio Sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.sBarraInferior.ResumeLayout(false);
            this.sBarraInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sBarraInferior;
        private System.Windows.Forms.Timer timerTiempoAplicacion;
        private System.Windows.Forms.Button btnTrabajo;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempo;
        private System.Windows.Forms.Label lblTiempoContador;
    }
}

