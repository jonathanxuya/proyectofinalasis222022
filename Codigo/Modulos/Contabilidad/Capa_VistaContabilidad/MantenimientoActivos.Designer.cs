﻿
namespace Capa_VistaContabilidad
{
    partial class MantenimientoActivos
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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel12 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton25 = new FontAwesome.Sharp.IconButton();
            this.iconButton12 = new FontAwesome.Sharp.IconButton();
            this.iconButton26 = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioPublico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.panel12.Controls.Add(this.panel18);
            this.panel12.Location = new System.Drawing.Point(13, 13);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1479, 575);
            this.panel12.TabIndex = 3;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 60;
            this.iconButton3.Location = new System.Drawing.Point(641, 191);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(100, 84);
            this.iconButton3.TabIndex = 31;
            this.iconButton3.Text = "Agregar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconButton8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 60;
            this.iconButton8.Location = new System.Drawing.Point(1100, 191);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(100, 84);
            this.iconButton8.TabIndex = 32;
            this.iconButton8.Text = "Cancelar";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // iconButton25
            // 
            this.iconButton25.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton25.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.iconButton25.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton25.IconSize = 60;
            this.iconButton25.Location = new System.Drawing.Point(766, 191);
            this.iconButton25.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton25.Name = "iconButton25";
            this.iconButton25.Size = new System.Drawing.Size(94, 84);
            this.iconButton25.TabIndex = 33;
            this.iconButton25.Text = "Buscar";
            this.iconButton25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton25.UseVisualStyleBackColor = true;
            // 
            // iconButton12
            // 
            this.iconButton12.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton12.IconColor = System.Drawing.Color.DimGray;
            this.iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton12.IconSize = 50;
            this.iconButton12.Location = new System.Drawing.Point(990, 191);
            this.iconButton12.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton12.Name = "iconButton12";
            this.iconButton12.Size = new System.Drawing.Size(92, 84);
            this.iconButton12.TabIndex = 34;
            this.iconButton12.Text = "Elimiar";
            this.iconButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton12.UseVisualStyleBackColor = true;
            // 
            // iconButton26
            // 
            this.iconButton26.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.iconButton26.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.iconButton26.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton26.IconSize = 60;
            this.iconButton26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton26.Location = new System.Drawing.Point(878, 191);
            this.iconButton26.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton26.Name = "iconButton26";
            this.iconButton26.Size = new System.Drawing.Size(94, 84);
            this.iconButton26.TabIndex = 35;
            this.iconButton26.Text = "Update";
            this.iconButton26.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton26.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtExistencias);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecioPublico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 183);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(602, 400);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Activos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(184, 55);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(199, 30);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 110);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(332, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(184, 165);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(332, 73);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio público:";
            // 
            // txtPrecioPublico
            // 
            this.txtPrecioPublico.Location = new System.Drawing.Point(184, 263);
            this.txtPrecioPublico.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioPublico.Name = "txtPrecioPublico";
            this.txtPrecioPublico.Size = new System.Drawing.Size(199, 30);
            this.txtPrecioPublico.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Existencias:";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(184, 326);
            this.txtExistencias.Margin = new System.Windows.Forms.Padding(4);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(199, 30);
            this.txtExistencias.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(417, 260);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 30);
            this.txtId.TabIndex = 13;
            this.txtId.Visible = false;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dataGridView1);
            this.panel18.Controls.Add(this.groupBox1);
            this.panel18.Controls.Add(this.iconButton26);
            this.panel18.Controls.Add(this.iconButton12);
            this.panel18.Controls.Add(this.iconButton25);
            this.panel18.Controls.Add(this.iconButton8);
            this.panel18.Controls.Add(this.iconButton3);
            this.panel18.Location = new System.Drawing.Point(4, 4);
            this.panel18.Margin = new System.Windows.Forms.Padding(4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1475, 548);
            this.panel18.TabIndex = 0;
            this.panel18.Paint += new System.Windows.Forms.PaintEventHandler(this.panel18_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(641, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(814, 228);
            this.dataGridView1.TabIndex = 37;
            // 
            // Activos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 935);
            this.Controls.Add(this.panel12);
            this.Name = "Activos";
            this.Text = "Activos";
            this.panel12.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioPublico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton26;
        private FontAwesome.Sharp.IconButton iconButton12;
        private FontAwesome.Sharp.IconButton iconButton25;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}