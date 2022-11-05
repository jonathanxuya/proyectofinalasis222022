
namespace Vista_Bancos
{
    partial class Cheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cheque));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDCuentaBancaria = new System.Windows.Forms.TextBox();
            this.txtIDConcepto = new System.Windows.Forms.TextBox();
            this.txtFechaReg = new System.Windows.Forms.TextBox();
            this.txtFechaAp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDBanco = new System.Windows.Forms.TextBox();
            this.txtMontoLetras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Concepto: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de registro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(580, 352);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(162, 27);
            this.txtMonto.TabIndex = 6;
            this.txtMonto.Tag = "montoNum_cheques";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Páguese este cheque a:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de aplicación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Suma de: ";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(204, 349);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(303, 28);
            this.comboBox2.TabIndex = 18;
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 28;
            this.navegador1.Load += new System.EventHandler(this.navegador2_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 483);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 257);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.Tag = "tbl_ctrl_cheques";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(67, 207);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(127, 27);
            this.txtID.TabIndex = 30;
            this.txtID.Tag = "Pk_idControl_cheques";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(200, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "ID Cuenta Bancaria:";
            // 
            // txtIDCuentaBancaria
            // 
            this.txtIDCuentaBancaria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCuentaBancaria.Location = new System.Drawing.Point(369, 207);
            this.txtIDCuentaBancaria.Name = "txtIDCuentaBancaria";
            this.txtIDCuentaBancaria.Size = new System.Drawing.Size(127, 27);
            this.txtIDCuentaBancaria.TabIndex = 32;
            this.txtIDCuentaBancaria.Tag = "fk_id_cuentabancaria";
            // 
            // txtIDConcepto
            // 
            this.txtIDConcepto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDConcepto.Location = new System.Drawing.Point(612, 207);
            this.txtIDConcepto.Name = "txtIDConcepto";
            this.txtIDConcepto.Size = new System.Drawing.Size(130, 27);
            this.txtIDConcepto.TabIndex = 33;
            this.txtIDConcepto.Tag = "fk_id_concepto";
            // 
            // txtFechaReg
            // 
            this.txtFechaReg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaReg.Location = new System.Drawing.Point(580, 316);
            this.txtFechaReg.Name = "txtFechaReg";
            this.txtFechaReg.Size = new System.Drawing.Size(162, 27);
            this.txtFechaReg.TabIndex = 34;
            this.txtFechaReg.Tag = "fechaReg_cheques";
            // 
            // txtFechaAp
            // 
            this.txtFechaAp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAp.Location = new System.Drawing.Point(579, 436);
            this.txtFechaAp.Name = "txtFechaAp";
            this.txtFechaAp.Size = new System.Drawing.Size(162, 27);
            this.txtFechaAp.TabIndex = 35;
            this.txtFechaAp.Tag = "fechaAplicacion_cheques";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID Banco:";
            // 
            // txtIDBanco
            // 
            this.txtIDBanco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBanco.Location = new System.Drawing.Point(282, 436);
            this.txtIDBanco.Name = "txtIDBanco";
            this.txtIDBanco.Size = new System.Drawing.Size(127, 27);
            this.txtIDBanco.TabIndex = 37;
            this.txtIDBanco.Tag = "fk_Banco_cheques";
            // 
            // txtMontoLetras
            // 
            this.txtMontoLetras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoLetras.Location = new System.Drawing.Point(115, 395);
            this.txtMontoLetras.Name = "txtMontoLetras";
            this.txtMontoLetras.Size = new System.Drawing.Size(626, 27);
            this.txtMontoLetras.TabIndex = 38;
            this.txtMontoLetras.Tag = "MontoLet_cheques";
            // 
            // Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 771);
            this.Controls.Add(this.txtMontoLetras);
            this.Controls.Add(this.txtIDBanco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFechaAp);
            this.Controls.Add(this.txtFechaReg);
            this.Controls.Add(this.txtIDConcepto);
            this.Controls.Add(this.txtIDCuentaBancaria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cheque";
            this.Text = "Cheque";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDCuentaBancaria;
        private System.Windows.Forms.TextBox txtIDConcepto;
        private System.Windows.Forms.TextBox txtFechaReg;
        private System.Windows.Forms.TextBox txtFechaAp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDBanco;
        private System.Windows.Forms.TextBox txtMontoLetras;
    }
}