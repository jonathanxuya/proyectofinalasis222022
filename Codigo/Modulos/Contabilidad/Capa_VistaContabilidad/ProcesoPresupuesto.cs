using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_VistaContabilidad
{
    public partial class MantenimientoPresupuesto : Form
    {
        public MantenimientoPresupuesto()
        {
            InitializeComponent();
        }
        Capa_ControladorContabilidad.controlador crud = new Capa_ControladorContabilidad.controlador();
        private void button1_Click(object sender, EventArgs e)
        {
            
            bool resultado = crud.Insertpresupuesto(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text });
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool resultado = crud.Updatepresupuesto(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text});
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool resultado = crud.Deletepresupuestos(textBox1.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { textBox1.Text });
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String col = "";
            String data = "";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    if (string.IsNullOrEmpty(textBox3.Text))
                    {
                        if (string.IsNullOrEmpty(textBox4.Text))
                        {
                            if (string.IsNullOrEmpty(textBox5.Text))
                            {
                                if (string.IsNullOrEmpty(textBox6.Text))
                                {
                                    if (string.IsNullOrEmpty(textBox7.Text))
                                       
                                        {
                                            if (string.IsNullOrEmpty(textBox8.Text))
                                            {
                                                if (string.IsNullOrEmpty(textBox9.Text))                                               
                                                {
                                                    if (string.IsNullOrEmpty(textBox10.Text))
                                                    {
                                                     
                                        String textalert = " El campo buscar, se encuentra vacio. Debe llenar un solo campo para realizar la busqueda";
                                        MessageBox.Show(textalert);
                                    }
                                    else
                                    {
                                        data = textBox9.Text;
                                        col = "anotacion";
                                    }
                                }
                                else
                                {
                                    data = textBox8.Text;
                                    col = "monto";
                                }
                            }
                            else
                            {
                                data = textBox7.Text;
                                col = "descripcion  ";
                            }
                        }
                        else
                        {
                            data = textBox6.Text;
                            col = "fecha";
                        }
                    }
                    else
                    {
                        data = textBox5.Text;
                        col = "nombre";
                    }
                }
                else
                {
                    data = textBox4.Text;
                    col = "PKidCuenta";
                }
                        }
                        else
                        {
                            data = textBox3.Text;
                            col = "PKidArea";
                        }
                    }
                    else
                    {
                        data = textBox2.Text;
                        col = "PKidMoneda";
                    }
                }
                else
                {
                    data = textBox1.Text;
                    col = "PKidpresupuesto";
                }
            }
            else
            {
                data = textBox10.Text;
                col = "status";
            }
            DataTable dt = new DataTable();
            //crud.BuscarProducto(data, col, dt);
            crud.BuscarDatop(data, col, dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            String table = "";
            DataTable dt = new DataTable();
            table = "tbl_presupuesto";
            crud.Actualizarp(table, dt);
            dataGridView1.DataSource = dt;
        }
    }
}
