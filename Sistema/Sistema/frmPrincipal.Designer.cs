namespace Sistema
{
    partial class frmPrincipal
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuConsultarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarSession = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(92, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(404, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuConfiguracion,
            this.menuCerrarSession});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarUsuario,
            this.subMenuConsultarUsuarios});
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(163, 20);
            this.menuUsuarios.Text = "Administración de usuarios";
            // 
            // subMenuRegistrarUsuario
            // 
            this.subMenuRegistrarUsuario.Name = "subMenuRegistrarUsuario";
            this.subMenuRegistrarUsuario.Size = new System.Drawing.Size(180, 22);
            this.subMenuRegistrarUsuario.Text = "Registrar";
            this.subMenuRegistrarUsuario.Click += new System.EventHandler(this.subMenuRegistrarUsuario_Click);
            // 
            // subMenuConsultarUsuarios
            // 
            this.subMenuConsultarUsuarios.Name = "subMenuConsultarUsuarios";
            this.subMenuConsultarUsuarios.Size = new System.Drawing.Size(180, 22);
            this.subMenuConsultarUsuarios.Text = "Consultar";
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(95, 20);
            this.menuConfiguracion.Text = "Configuración";
            // 
            // menuCerrarSession
            // 
            this.menuCerrarSession.Name = "menuCerrarSession";
            this.menuCerrarSession.Size = new System.Drawing.Size(88, 20);
            this.menuCerrarSession.Text = "Cerrar Sesión";
            this.menuCerrarSession.Click += new System.EventHandler(this.menuCerrarSession_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem subMenuConsultarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSession;
    }
}