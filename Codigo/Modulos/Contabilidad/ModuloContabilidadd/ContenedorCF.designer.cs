
namespace ModuloContabilidadd
{
    partial class ContenedorCF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContenedorCF));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salir = new FontAwesome.Sharp.IconButton();
            this.btn_Polizas = new FontAwesome.Sharp.IconButton();
            this.btn_AcivosF = new FontAwesome.Sharp.IconButton();
            this.btn_Presupuestos = new FontAwesome.Sharp.IconButton();
            this.btn_CierreC = new FontAwesome.Sharp.IconButton();
            this.btn_EstadosD = new FontAwesome.Sharp.IconButton();
            this.btn_Mantenimientos = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.btn_Polizas);
            this.panel1.Controls.Add(this.btn_AcivosF);
            this.panel1.Controls.Add(this.btn_Presupuestos);
            this.panel1.Controls.Add(this.btn_CierreC);
            this.panel1.Controls.Add(this.btn_EstadosD);
            this.panel1.Controls.Add(this.btn_Mantenimientos);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 476);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Salir.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.Black;
            this.btn_Salir.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowRight;
            this.btn_Salir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Salir.IconSize = 45;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(19, 423);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(152, 50);
            this.btn_Salir.TabIndex = 14;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Polizas
            // 
            this.btn_Polizas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Polizas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Polizas.IconChar = FontAwesome.Sharp.IconChar.FileShield;
            this.btn_Polizas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_Polizas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Polizas.IconSize = 40;
            this.btn_Polizas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Polizas.Location = new System.Drawing.Point(19, 19);
            this.btn_Polizas.Name = "btn_Polizas";
            this.btn_Polizas.Size = new System.Drawing.Size(152, 50);
            this.btn_Polizas.TabIndex = 13;
            this.btn_Polizas.Text = "   Polizas Locales";
            this.btn_Polizas.UseVisualStyleBackColor = false;
            this.btn_Polizas.Click += new System.EventHandler(this.btn_Polizas_Click);
            // 
            // btn_AcivosF
            // 
            this.btn_AcivosF.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AcivosF.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcivosF.IconChar = FontAwesome.Sharp.IconChar.BuildingCircleCheck;
            this.btn_AcivosF.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_AcivosF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AcivosF.IconSize = 40;
            this.btn_AcivosF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AcivosF.Location = new System.Drawing.Point(19, 75);
            this.btn_AcivosF.Name = "btn_AcivosF";
            this.btn_AcivosF.Size = new System.Drawing.Size(152, 50);
            this.btn_AcivosF.TabIndex = 12;
            this.btn_AcivosF.Text = "Activos Fijos";
            this.btn_AcivosF.UseVisualStyleBackColor = false;
            this.btn_AcivosF.Click += new System.EventHandler(this.btn_AcivosF_Click);
            // 
            // btn_Presupuestos
            // 
            this.btn_Presupuestos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Presupuestos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Presupuestos.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btn_Presupuestos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_Presupuestos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Presupuestos.IconSize = 40;
            this.btn_Presupuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Presupuestos.Location = new System.Drawing.Point(19, 131);
            this.btn_Presupuestos.Name = "btn_Presupuestos";
            this.btn_Presupuestos.Size = new System.Drawing.Size(152, 50);
            this.btn_Presupuestos.TabIndex = 11;
            this.btn_Presupuestos.Text = "    Presupuestos";
            this.btn_Presupuestos.UseVisualStyleBackColor = false;
            this.btn_Presupuestos.Click += new System.EventHandler(this.btn_Presupuestos_Click);
            // 
            // btn_CierreC
            // 
            this.btn_CierreC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CierreC.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CierreC.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btn_CierreC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_CierreC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CierreC.IconSize = 40;
            this.btn_CierreC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CierreC.Location = new System.Drawing.Point(19, 187);
            this.btn_CierreC.Name = "btn_CierreC";
            this.btn_CierreC.Size = new System.Drawing.Size(152, 50);
            this.btn_CierreC.TabIndex = 10;
            this.btn_CierreC.Text = "         Cierre Contable";
            this.btn_CierreC.UseVisualStyleBackColor = false;
            this.btn_CierreC.Click += new System.EventHandler(this.btn_Fiscales_Click);
            // 
            // btn_EstadosD
            // 
            this.btn_EstadosD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_EstadosD.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EstadosD.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btn_EstadosD.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_EstadosD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EstadosD.IconSize = 40;
            this.btn_EstadosD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EstadosD.Location = new System.Drawing.Point(19, 243);
            this.btn_EstadosD.Name = "btn_EstadosD";
            this.btn_EstadosD.Size = new System.Drawing.Size(152, 50);
            this.btn_EstadosD.TabIndex = 9;
            this.btn_EstadosD.Text = "           Estados Financieros";
            this.btn_EstadosD.UseVisualStyleBackColor = false;
            this.btn_EstadosD.Click += new System.EventHandler(this.btn_EstadosD_Click);
            // 
            // btn_Mantenimientos
            // 
            this.btn_Mantenimientos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Mantenimientos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mantenimientos.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btn_Mantenimientos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_Mantenimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Mantenimientos.IconSize = 40;
            this.btn_Mantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mantenimientos.Location = new System.Drawing.Point(19, 299);
            this.btn_Mantenimientos.Name = "btn_Mantenimientos";
            this.btn_Mantenimientos.Size = new System.Drawing.Size(152, 50);
            this.btn_Mantenimientos.TabIndex = 8;
            this.btn_Mantenimientos.Text = "       Mantenimientos";
            this.btn_Mantenimientos.UseVisualStyleBackColor = false;
            this.btn_Mantenimientos.Click += new System.EventHandler(this.btn_Mantenimientos_Click);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(178, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 484);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ContenedorCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ContenedorCF";
            this.Text = "Contenedor Contabilidad y Finanzas";
            this.Load += new System.EventHandler(this.ContenedorCF_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_Mantenimientos;
        private FontAwesome.Sharp.IconButton btn_Salir;
        private FontAwesome.Sharp.IconButton btn_Polizas;
        private FontAwesome.Sharp.IconButton btn_AcivosF;
        private FontAwesome.Sharp.IconButton btn_Presupuestos;
        private FontAwesome.Sharp.IconButton btn_CierreC;
        private FontAwesome.Sharp.IconButton btn_EstadosD;
    }
}

