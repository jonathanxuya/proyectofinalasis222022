
namespace Capa_VistaContabilidad
{
    partial class MantenimientoDetallePolizaContable
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textIDCuenta = new System.Windows.Forms.TextBox();
            this.textIDTPoliza = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textConcepto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textIDPoliza = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPolizaDetalle = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.navegador1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1067, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegador";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(16, 25);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1041, 222);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textIDCuenta);
            this.groupBox2.Controls.Add(this.textIDTPoliza);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textConcepto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textSaldo);
            this.groupBox2.Controls.Add(this.textIDPoliza);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.groupBox2.Location = new System.Drawing.Point(17, 310);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1057, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // textIDCuenta
            // 
            this.textIDCuenta.Location = new System.Drawing.Point(783, 46);
            this.textIDCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textIDCuenta.Name = "textIDCuenta";
            this.textIDCuenta.Size = new System.Drawing.Size(132, 25);
            this.textIDCuenta.TabIndex = 16;
            this.textIDCuenta.Tag = "pkid_cuenta";
            // 
            // textIDTPoliza
            // 
            this.textIDTPoliza.Location = new System.Drawing.Point(476, 48);
            this.textIDTPoliza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textIDTPoliza.Name = "textIDTPoliza";
            this.textIDTPoliza.Size = new System.Drawing.Size(155, 25);
            this.textIDTPoliza.TabIndex = 15;
            this.textIDTPoliza.Tag = "Pk_TipoPoliza";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 150);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 25);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Tag = "fechaPoliza";
            // 
            // textConcepto
            // 
            this.textConcepto.Location = new System.Drawing.Point(127, 197);
            this.textConcepto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textConcepto.Multiline = true;
            this.textConcepto.Name = "textConcepto";
            this.textConcepto.Size = new System.Drawing.Size(340, 82);
            this.textConcepto.TabIndex = 13;
            this.textConcepto.Tag = "concepto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label6.Location = new System.Drawing.Point(668, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(325, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Tipo Poliza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(24, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Poliza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(49, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo";
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(128, 95);
            this.textSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(141, 25);
            this.textSaldo.TabIndex = 4;
            this.textSaldo.Tag = "saldo";
            // 
            // textIDPoliza
            // 
            this.textIDPoliza.Location = new System.Drawing.Point(128, 50);
            this.textIDPoliza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textIDPoliza.Name = "textIDPoliza";
            this.textIDPoliza.Size = new System.Drawing.Size(141, 25);
            this.textIDPoliza.TabIndex = 3;
            this.textIDPoliza.Tag = "Pk_PolizaEncabezado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "Docto";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concepto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPolizaDetalle);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.groupBox3.Location = new System.Drawing.Point(17, 650);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1056, 257);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // dgvPolizaDetalle
            // 
            this.dgvPolizaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizaDetalle.Location = new System.Drawing.Point(8, 25);
            this.dgvPolizaDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPolizaDetalle.Name = "dgvPolizaDetalle";
            this.dgvPolizaDetalle.RowHeadersWidth = 51;
            this.dgvPolizaDetalle.Size = new System.Drawing.Size(1027, 209);
            this.dgvPolizaDetalle.TabIndex = 0;
            this.dgvPolizaDetalle.Tag = "tbl_polizadetalle";
            // 
            // MantenimientoDetallePolizaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1111, 922);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenimientoDetallePolizaContable";
            this.Text = "Poliza Contable Detalle";
            this.Load += new System.EventHandler(this.MantenimientoPolizaContable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.TextBox textIDPoliza;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textConcepto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPolizaDetalle;
        private System.Windows.Forms.TextBox textIDCuenta;
        private System.Windows.Forms.TextBox textIDTPoliza;
    }
}