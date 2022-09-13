﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace BusquedaInteligente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       /*private void button1_Click(object sender, EventArgs e)
        {
            bool resultado = crud.InsertBusqueda(textBox12.Text, textBox14.Text, textBox15.Text, textBox11.Text);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }
       */
        CRUD crud = new CRUD();

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bool resultado = crud.InsertBusqueda(textBox12.Text, textBox14.Text, textBox15.Text, textBox11.Text);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }

        }
       
        private void iconButton7_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox11.Clear();

            
        }

        CRUDC crudc = new CRUDC();
        private void iconButton3_Click(object sender, EventArgs e)
        {
            bool resultado = crudc.InsertBusquedaCompleja(textBox16.Text, textBox17.Text, textBox10.Text);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            textBox16.Clear();
            textBox17.Clear();
            textBox10.Clear();
            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            textBox18.Clear();
            textBox19.Clear();
            textBox9.Clear();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            {

                {
                    MessageBox.Show("Datos guardados");
                }
            }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            textBox20.Clear();
            textBox21.Clear();
            textBox8.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            textBox20.Clear();
            textBox21.Clear();
            textBox8.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox9.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox10.Clear();
            textBox12.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox11.Clear();

        }
    }
}
