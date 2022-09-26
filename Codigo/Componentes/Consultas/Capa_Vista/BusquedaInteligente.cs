using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_ControladorConsultas;
using System.Data.Odbc;

namespace Capa_Vista
{

    public partial class Busqueda : Form
    {

        clscontrolador cn = new clscontrolador();
                    
        
        string campo = "";
        string csimple = "";
        string where = "";
        string and = "";
        string group = "";
        string final = "";
        string orden = "";


        public Busqueda()
        {
            InitializeComponent();
        }
        string consulta = "";
        public void actualizardatagrid()
        {
            DataTable dt = cn.llenartb1(consulta);
            dataGridView2.DataSource = dt;
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


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
           bool resultado = crud.InsertBusqueda(txtNombreConsulta.Text, cboTabla.Text, comboBox11.Text, textBox11.Text, null);
            
            if (resultado)

            {
                MessageBox.Show("Datos guardados");
            }

           textBox1.Text = (txtNombreConsulta.Text + "+" + cboTabla.Text + "+" + comboBox11.Text + "+" + textBox11.Text);

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            comboBox11.ResetText();
            textBox11.Clear();



        }

        
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
            bool resultado = crud.InsertBusquedaCompleja(comboBox13.Text, comboBox12.Text, textBox16.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
            bool resultado = crud.InsertBusquedaCompleja(comboBox14.Text, comboBox15.Text, textBox9.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();
        }

        private void iconButton5_Click(object sender, EventArgs e)

        {
            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
            bool resultado = crud.InsertBusquedaCompleja1(comboBox16.Text, comboBox17.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            comboBox16.ResetText();
            comboBox17.ResetText();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            comboBox11.ResetText();
            textBox11.Clear();
            comboBox16.ResetText();
            comboBox17.ResetText();
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();
            comboBox14.ResetText();
            comboBox15.ResetText();
            textBox9.Clear();

        }

  
        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
          
           // textBox1.Text = txtNombreConsulta.Text+ cboTabla.Text+ comboBox11.Text+ textBox11.Text;
        }

        //se necesita actualizaciones para terminar boton eliminar
        //Diana Victores 9959-19-1471
        public void actualizaconsultas()
        {
          
        }

        //boton eliminar de la forma Buscar/Eliminar - Diana Victores 9959-19-1471
        private void iconButton12_Click(object sender, EventArgs e)
        {
            cn.ejecutarconsulta(txtNombreConsultaBUSCARyELIMINAR.Text);
            MessageBox.Show("Las consultas con nombre " + txtNombreConsultaBUSCARyELIMINAR.Text + " Han sido eliminadas");
            actualizaconsultas();
            txtNombreConsultaBUSCARyELIMINAR.Text = "";
        }
        public void actualizaconsultas2(string condicion)
        {
            DataTable dt = cn.llenartb3(condicion);
            dgvBUSCARyELIMINAR.DataSource = dt;
        }
        private void ConsultasInteligentes_Load(object sender, EventArgs e)
        {
            
            llenarcboquery();
            llenarcomboeditar();
            tablaseditar();
        }

        public void llenarcomboeditar()
        {
            cbonombreconsulta.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbonombreconsulta();
            while (datareader.Read())
            {
                cbonombreconsulta.Items.Add(datareader[0].ToString());
            }
        }

        public void llenarcombosactualizar()
        {
            cboCamposEDITAR.Items.Clear();
            cboCampoConsultaComplejaEDITAR.Items.Clear();
            cboCampoEDITAR.Items.Clear();
            cboCampoAgruparEDITAR.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo2(txttablaeditar.Text);
            while (datareader.Read())
            {
                cboCamposEDITAR.Items.Add(datareader[0].ToString());
                cboCampoConsultaComplejaEDITAR.Items.Add(datareader[0].ToString());
                cboCampoEDITAR.Items.Add(datareader[0].ToString());
                cboCampoAgruparEDITAR.Items.Add(datareader[0].ToString());
            }
        }


        private void cbonombreconsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTablaConsultaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttablaeditar.Text = cboTablaConsultaSimple.SelectedItem.ToString();
            llenarcombosactualizar();
            chkSelectTodosConsultaSimple.Enabled = true;
        }

        public void tablaseditar()
        {
            cboTabla.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo();
            while (datareader.Read())
            {
                cboTablaConsultaSimple.Items.Add(datareader[0].ToString());
            }
        }

        string query = "registro_consultas";
        public void llenarcboquery()
        {
            cboQueryy.Items.Clear();
            cbosubquery.Items.Clear();
            OdbcDataReader datareader = cn.llenarcboq(query);
            while (datareader.Read())
            {
                cboQueryy.Items.Add(datareader[0].ToString());
                cbosubquery.Items.Add(datareader[1].ToString());
            }
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            finaleditar = csimpleeditar + " " + whereeditar + " " + andeditar + " " + groupeditar + ";";
            if (csimpleeditar == "")
            {
                MessageBox.Show("Consulta incorrecta");
            }
            else
            {
                MessageBox.Show("Consulta Almacenada");
                cn.editarconsulta(txtTablaConsultaSimple.Text, finaleditar);
                llenarcboquery();
            }
            txtCadenaGeneradaEDITAR.Text = "";
            chkcondicioneseditar.Checked = false;
            txtcamposelectoseditar.Text = "";
            txtNombreRepresentativoEDITAR.Text = "";
            finaleditar = "";
            csimpleeditar = "";
            whereeditar = "";
            andeditar = "";
            groupeditar = "";
            cbonombreconsulta.Text = "";
            cbonombreconsulta.Enabled = true;
        }

        string transfiere = "";
        string campoeditar = "";
        string csimpleeditar = "";
        string whereeditar = "";
        string andeditar = "";
        string ordeneditar = "";
        string groupeditar = "";
        string finaleditar = "";

        private void iconButton26_Click(object sender, EventArgs e)
        {
            transfiere = txtNombreConsultaBUSCARyELIMINAR.Text;
            cbonombreconsulta.Text = transfiere;
            txtTablaConsultaSimple.Text = transfiere;
            groupBox2.Enabled = true;
            tbpBE.Hide();
            tbpEditar.Show();

        }

        private void iconButton28_Click(object sender, EventArgs e)
        {
            actualizaconsultas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboCampoAgruparEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboAgruparEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAgruparEDITAR.SelectedIndex == 1)
            {
                groupBox7.Enabled = true;
            }
            else
            {
                groupBox7.Enabled = false;
                rdbAscEDITAR.Checked = false;
                rdbdescEDITAR.Checked = false;
            }
        }

        private void btnAgregarAgruparOrdenarEDITAR_Click(object sender, EventArgs e)
        {
            if (rdbdescEDITAR.Checked == true)
            {
                ordeneditar = "desc";
            }
            else
            {
                ordeneditar = "asc";
            }


            if ((cboAgruparEDITAR.Text == "") || (cboCampoAgruparEDITAR.Text == ""))
            {
                MessageBox.Show("Debe utilizar todos los campos de agrupacion");
            }
            else
            {
                if (cboAgruparEDITAR.SelectedIndex == 0)
                {
                    groupeditar = "group by " + cboCampoAgruparEDITAR.SelectedItem.ToString();
                }
                else if (cboAgruparEDITAR.SelectedIndex == 1)
                {
                    groupeditar = "order by " + cboCampoAgruparEDITAR.SelectedItem.ToString() + " " + ordeneditar;

                }
                txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar + andeditar + groupeditar;
            }
        }

        private void btnAgregarComparacionEDITAR_Click(object sender, EventArgs e)
        {
            if ((cboTipoComparadorEDITAR.Text == "") || (cboCampoEDITAR.Text == "") || (txtValorComparacionEDITAR.Text == "") || (cbocompwhere.Text == ""))
            {
                MessageBox.Show("Clausula where estructurada erroneamente");
            }
            else
            {
                if (cbocompwhere.SelectedItem.ToString() == "like")
                {
                    whereeditar = cboTipoComparadorEDITAR.SelectedItem.ToString() + " " + cboCampoEDITAR.SelectedItem.ToString() + " " +
                    cbocompwhere.SelectedItem.ToString() + " " + '"' + "%" + txtValorComparacionEDITAR.Text + "%" + '"' + " ";
                    txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar;
                }
                else
                {
                    whereeditar = cboTipoComparadorEDITAR.SelectedItem.ToString() + " " + cboCampoEDITAR.SelectedItem.ToString() + " " +
                    cbocompwhere.SelectedItem.ToString() + '"' + txtValorComparacionEDITAR.Text + '"' + " ";
                    txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar;
                }
            }
        }

        private void btnagregarCONSULTACOMPLEJAEDITAR_Click(object sender, EventArgs e)
        {
            if ((cboOperadorLogicoEDITAR.Text == "") || (cboCampoConsultaComplejaEDITAR.Text == "") || (txtvalorConsultaComplejaEDITAR.Text == ""))
            {
                MessageBox.Show("Utilice todos los campos logicos");
            }
            else
            {

                if (whereeditar != "")
                {
                    if (cbocompand.SelectedItem.ToString() == "like")
                    {
                        andeditar = andeditar + cboOperadorLogicoEDITAR.SelectedItem.ToString() + " "
                         + cboCampoConsultaComplejaEDITAR.SelectedItem.ToString() + " " +
                        cbocompand.SelectedItem.ToString() + " " + '"' + "%" + txtvalorConsultaComplejaEDITAR.Text + " %" + '"' + " ";
                        txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar + andeditar;
                    }
                    else
                    {
                        andeditar = andeditar + cboOperadorLogicoEDITAR.SelectedItem.ToString() + " "
                         + cboCampoConsultaComplejaEDITAR.SelectedItem.ToString() + " " +
                        cbocompand.SelectedItem.ToString() + " " + '"' + txtvalorConsultaComplejaEDITAR.Text + '"' + " ";
                        txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar + andeditar;
                    }
                }
                else
                {
                    andeditar = "";
                    MessageBox.Show("Para agregar un comparador debe seleccionar un where");


                }
            }
        }

        private void chkcondicioneseditar_CheckedChanged(object sender, EventArgs e)
        {
            if ((chkcondicioneseditar.Checked == true) && (csimpleeditar != ""))
            {
                groupBox4.Enabled = true;
                groupBox6.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
                groupBox6.Enabled = false;
                chkcondicioneseditar.Checked = false;
            }
        }

        private void btnagregarcamposeditar_Click(object sender, EventArgs e)
        {
            if (campoeditar == "")
            {
                MessageBox.Show("Debe seleccionar al menos un campo");
            }
            else
            {
                csimpleeditar = "SELECT " + campoeditar + "FROM " + txttablaeditar.Text + " ";
                Console.WriteLine(csimpleeditar);
                txtCadenaGeneradaEDITAR.Text = csimpleeditar;
                campoeditar = "";
                txtNombreRepresentativoEDITAR.Text = "";
                cboCamposEDITAR.Text = "";
                txtcamposelectoseditar.Text = "";
                cboTablaConsultaSimple.Text = "";
                chkSelectTodosConsultaSimple.Checked = false;
                cbonombreconsulta.Enabled = false;
            }
        }

        private void btnAgregarCONSULTASIMPLE_Click(object sender, EventArgs e)
        {
            if (chkSelectTodosConsultaSimple.Checked == false)
            {
                if (txtcamposelectoseditar.Text.Equals(""))
                {
                    if (txtNombreRepresentativoEDITAR.Text.Equals(""))
                    {
                        txtcamposelectoseditar.Text = "";
                        campoeditar = campoeditar + cboCamposEDITAR.SelectedItem.ToString() + " ";
                        txtcamposelectoseditar.Text = campoeditar;
                    }
                    else
                    {
                        txtcamposelectoseditar.Text = "";
                        campoeditar = campoeditar + cboCamposEDITAR.SelectedItem.ToString() + " as " + txtNombreRepresentativoEDITAR.Text + " ";
                        txtcamposelectoseditar.Text = campoeditar;
                    }
                }
                else
                {
                    if (txtNombreRepresentativoEDITAR.Text.Equals(""))
                    {
                        txtcamposelectoseditar.Text = "";
                        campoeditar = campoeditar + ", " + cboCamposEDITAR.SelectedItem.ToString() + " ";
                        txtcamposelectoseditar.Text = campoeditar;
                    }
                    else
                    {
                        txtcamposelectoseditar.Text = "";
                        campoeditar = campoeditar + ", " + cboCamposEDITAR.SelectedItem.ToString() + " as " + txtNombreRepresentativoEDITAR.Text + " ";
                        txtcamposelectoseditar.Text = campoeditar;
                    }
                }
            }
            else
            {
                txtcamposelectoseditar.Text = "";
                campoeditar = "";
                campoeditar = " * ";
                txtcamposelectoseditar.Text = "Todos los campos seleccionados";
                Console.WriteLine(campoeditar);
            }
        }

        private void chkSelectTodosConsultaSimple_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectTodosConsultaSimple.Checked == true)
            {
                txtNombreRepresentativoEDITAR.Text = "";
                txtNombreRepresentativoEDITAR.Enabled = false;
                cboCamposEDITAR.Text = "";
                cboCamposEDITAR.Enabled = false;
                txtcamposelectoseditar.Text = "";
            }
            else
            {
                txtNombreRepresentativoEDITAR.Text = "";
                txtNombreRepresentativoEDITAR.Enabled = true;
                cboCamposEDITAR.Text = "";
                cboCamposEDITAR.Enabled = true;
            }
        }

        private void iconButton25_Click(object sender, EventArgs e)
        {
            actualizaconsultas2(txtNombreConsultaBUSCARyELIMINAR.Text);
        }

        private void btnActualizarBUSCARyELIMINAR_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
            textBox8.Text = "SELECT FROM" + "*"+ "_" + "WHERE" + query + "_" + "INSERTED" + "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        


            if (checkBox3.Checked == true)
            
            {
                panel15.Enabled = true;
                panel13.Enabled = true;
            }else
            {
                panel15.Enabled = false;
                panel13.Enabled = false;
                checkBox3.Checked = false;

            }
            

        }

        public void habilitaciones()
        {
            panel15.Enabled = false;
            panel13.Enabled = false;
            checkBox3.Checked = false;
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboQueryy.SelectedIndex = cboQueryy.SelectedIndex;
            txtCadenaGeneradaConsulta.Text = cboQueryy.SelectedItem.ToString();
            consulta = txtCadenaGeneradaConsulta.Text;
        }

        private void cbosubquery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton27_Click(object sender, EventArgs e)
        {
            actualizardatagrid();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = cn.llenartb1(consulta);
            dataGridView2.DataSource = dt;
        }

        private void cbonombreconsulta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTablaConsultaSimple.Text = cbonombreconsulta.SelectedItem.ToString();
            groupBox2.Enabled = true;
        }
    }
    }
    



