using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

using Capa_Modelo;

namespace Capa_Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Capa_Modelo.CRUD crud = new Capa_Modelo.CRUD();


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bool resultado = crud.InsertBusqueda(textBox12.Text, comboBox10.Text, comboBox11.Text, textBox11.Text);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }

        }


        private void iconButton7_Click(object sender, EventArgs e)
        {
            textBox12.Clear();

            textBox11.Clear();


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            bool resultado = crud.InsertBusquedaCompleja(comboBox13.Text, comboBox12.Text, textBox16.Text);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            textBox16.Clear();

            textBox10.Clear();

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            bool resultado = crud.InsertBusquedaCompleja(comboBox14.Text, comboBox15.Text, textBox9.Text);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {

            textBox9.Clear();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            bool resultado = crud.InsertBusquedaCompleja1(comboBox16.Text, comboBox17.Text);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {

            textBox8.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            textBox8.Clear();
            textBox9.Clear();
            textBox16.Clear();
            textBox10.Clear();
            textBox12.Clear();
            textBox11.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "ColumnDgvModificar")
                    {
                        textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }

                    if (dataGridView1.Columns[e.ColumnIndex].Name == "ColumnDgvElimnar")
                    {
                        //string ope = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        // bool resultado = crud.EliminarBusqueda(ope);
                        // if (resultado)
                        {
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
        //se necesita actualizaciones para terminar boton eliminar
        //Diana Victores 9959-19-1471
        public void actualizaconsultas()
        {

        }

        //boton eliminar
        //diana victores

        private void iconButton12_Click(object sender, EventArgs e)
        {
            //cn.ejecutarconsulta(textConsultaBusqueda.Text);
            MessageBox.Show("Las consultas con nombre " + textConsultaBusqueda.Text + " Han sido eliminadas");
            actualizaconsultas();

            textConsultaBusqueda.Text = "";
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}