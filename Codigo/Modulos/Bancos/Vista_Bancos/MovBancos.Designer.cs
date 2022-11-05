
namespace Vista_Bancos
{
    partial class MovBancos
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 29;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.Tag = "Pk_idMovimientos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Pago";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 33;
            this.textBox2.Tag = "fk_tipo_pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Concepto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Banco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cuenta Relación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Moneda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Monto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "IVA";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 319);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 41;
            this.textBox3.Tag = "fk_id_concepto";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 355);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 42;
            this.textBox4.Tag = "fecha_mov";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 392);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 43;
            this.textBox5.Tag = "fk_Cuenta_banco";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(176, 425);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 44;
            this.textBox6.Tag = "fk_Cuenta_rela";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(176, 461);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 45;
            this.textBox7.Tag = "fk_tipomoneda";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(176, 497);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 46;
            this.textBox8.Tag = "Monto_mov";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(543, 494);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 47;
            this.textBox9.Tag = "iva_mov";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 537);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 150);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.Tag = "tbl_movimientos_bancos";
            // 
            // MovBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 711);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.navegador1);
            this.Name = "MovBancos";
            this.Text = "Movimientos Bancos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}