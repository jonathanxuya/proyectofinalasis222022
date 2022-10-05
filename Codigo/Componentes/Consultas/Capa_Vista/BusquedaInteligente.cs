﻿using System;
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
        OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");

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
            CargarTablas();

        }
        string consulta = "";
        public void actualizardatagrid()
        {
            DataTable dt = cn.llenartb1(consulta);
            dataGridView2.DataSource = dt;
        }

        public void CargarTablas()
        {
            con.Open();
            cboTabla.DataSource = con.GetSchema("Tables");
            cboTabla.DisplayMember = "TABLE_NAME";
            con.Close();


        }

        public void CargarColumnas(string tablabusqueda, ComboBox comboBox11)
        {
            try
            {
                con.Open();
                String cadenaB;
                DataTable dt = new DataTable();
                cadenaB = "";

                cadenaB = " SELECT * FROM " + tablabusqueda;
                //lbl_cadena.Text = "Buscando : " + datobuscar + " En Columna : " + buscaren;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                DataGridView colums = new DataGridView();
                colums.DataSource = dt;
                int ndgv = colums.Columns.Count;

                for (int i = 0; i < ndgv; i++)
                {
                    String nameC;
                    nameC = colums.Columns[i].HeaderText;
                    int ncbx = cboTabla.Items.Count;

                    if (ncbx < ndgv)
                    {
                        comboBox11.Items.Add(nameC);
                    }

                }
                for (int i = 0; i < ndgv; i++)
                {
                    String nameD;
                    nameD = colums.Columns[i].HeaderText;
                    int ncbx = cboTablaConsultaSimple.Items.Count;

                    if (ncbx < ndgv)
                    {
                        cboCamposEDITAR.Items.Add(nameD);
                    }
                }
                for (int i = 0; i < ndgv; i++)
                {
                    String nameE;
                    nameE = colums.Columns[i].HeaderText;
                    int ncbx = cboOperadorLogicoEDITAR.Items.Count;

                    if (ncbx < ndgv)
                    {
                        cboCampoConsultaComplejaEditar.Items.Add(nameE);
                    }
                }
                for (int i = 0; i < ndgv; i++)
                {
                    String nameE;
                    nameE = colums.Columns[i].HeaderText;
                    int ncbx = cboTipoComparadorEditar.Items.Count;

                    if (ncbx < ndgv)
                    {
                        cboCampoEditar.Items.Add(nameE);
                    }
                }
                for (int i = 0; i < ndgv; i++)
                {
                    String nameF;
                    nameF = colums.Columns[i].HeaderText;
                    int ncbx = cboAgruparEditar.Items.Count;

                    if (ncbx < ndgv)
                    {
                        cboCampoAgruparEditar.Items.Add(nameF);
                    }
                }
            }
            catch
            {
            }
            con.Close();

        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
            bool resultado = crud.InsertBusqueda(txtNombreConsulta.Text, cboTabla.Text, comboBox11.Text, textBox11.Text, null);

            if (resultado)

            {
                MessageBox.Show("Datos guardados");
            }

            textBox1.Text = (txtNombreConsulta.Text + "+" + cboTabla.Text + "+" + comboBox11.Text + "+" + textBox11.Text);
            string columnasbd = comboBox11.Text;
            CargarColumnas(columnasbd, comboBox11);
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
            cn.ejecutarconsulta(txtNombreConsultaBusquedaElimar.Text);
            MessageBox.Show("Las consultas con nombre " + txtNombreConsultaBusquedaElimar.Text + " Han sido eliminadas");
            actualizaconsultas();
            txtNombreConsultaBusquedaElimar.Text = "";
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
            cbonombrebuscar.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbonombreconsulta();
            while (datareader.Read())
            {
                cbonombrebuscar.Items.Add(datareader[0].ToString());
            }
        }

        public void llenarcombosactualizar()
        {
            cboCamposEDITAR.Items.Clear();
            cboCampoConsultaComplejaEditar.Items.Clear();
            cboCampoEditar.Items.Clear();
            cboCampoAgruparEditar.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbodatabase2(txttablaeditar.Text);
            while (datareader.Read())
            {
                cboCamposEDITAR.Items.Add(datareader[0].ToString());
                cboCampoConsultaComplejaEditar.Items.Add(datareader[0].ToString());
                cboCampoEditar.Items.Add(datareader[0].ToString());
                cboCampoAgruparEditar.Items.Add(datareader[0].ToString());
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
            OdbcDataReader datareader = cn.llenarcbodatabase();
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
                cn.editarconsulta(txtTablaConsulta.Text, finaleditar);
                llenarcboquery();
            }
            txtCadenaGeneradaEDITAR.Text = "";
            chkcondicioneseditar.Checked = false;
            txtcamposelectoseditar.Text = "";
            txtNombreAlias.Text = "";
            finaleditar = "";
            csimpleeditar = "";
            whereeditar = "";
            andeditar = "";
            groupeditar = "";
            cbonombrebuscar.Text = "";
            cbonombrebuscar.Enabled = true;
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
            transfiere = txtNombreConsultaBusquedaElimar.Text;
            cbonombrebuscar.Text = transfiere;
            txtTablaConsulta.Text = transfiere;
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
            if (cboAgruparEditar.SelectedIndex == 1)
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
            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
            bool resultado = crud.InsertBusquedaCompleja1(cboAgruparEditar.Text, cboCampoAgruparEditar.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void btnAgregarComparacionEDITAR_Click(object sender, EventArgs e)
        {
            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
            bool resultado = crud.InsertBusquedaCompleja(cboTipoComparadorEditar.Text, cboCampoEditar.Text, txtValorComparacionEDITAR.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void btnagregarCONSULTACOMPLEJAEDITAR_Click(object sender, EventArgs e)
        {
            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
            bool resultado = crud.InsertBusquedaCompleja(cboOperadorLogicoEDITAR.Text, cboCampoConsultaComplejaEditar.Text, txtvalorConsultaComplejaEDITAR.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void chkcondicioneseditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcondicioneseditar.Checked == true)

            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
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
                txtNombreAlias.Text = "";
                cboCamposEDITAR.Text = "";
                txtcamposelectoseditar.Text = "";
                cboTablaConsultaSimple.Text = "";
                chkSelectTodosConsultaSimple.Checked = false;
                cbonombrebuscar.Enabled = false;
            }
        }

        private void btnAgregarCONSULTASIMPLE_Click(object sender, EventArgs e)
        {
            Capa_ControladorConsultas.clscontrolador crud = new Capa_ControladorConsultas.clscontrolador();
            bool resultado = crud.InsertBusqueda(txtNombreConsulta.Text, cboTabla.Text, comboBox11.Text, textBox11.Text, null);

            if (resultado)

            {
                MessageBox.Show("Datos guardados");
            }

            txtTablaConsulta.Text = (txtcamposelectoseditar.Text + "+" + cboTablaConsultaSimple.Text + "+" + cboCamposEDITAR.Text + "+" + txtNombreAlias.Text);
            string columnasbd = comboBox11.Text;
            CargarColumnas(columnasbd, comboBox11);
        }

        private void chkSelectTodosConsultaSimple_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectTodosConsultaSimple.Checked == true)
            {
                txtNombreAlias.Text = "";
                txtNombreAlias.Enabled = false;
                cboCamposEDITAR.Text = "";
                cboCamposEDITAR.Enabled = false;
                txtcamposelectoseditar.Text = "";
            }
            else
            {
                txtNombreAlias.Text = "";
                txtNombreAlias.Enabled = true;
                cboCamposEDITAR.Text = "";
                cboCamposEDITAR.Enabled = true;
            }
        }

        private void iconButton25_Click(object sender, EventArgs e)
        {
            actualizaconsultas2(txtNombreConsultaBusquedaElimar.Text);
        }

        private void btnActualizarBUSCARyELIMINAR_Click(object sender, EventArgs e)
        {
            transfiere = txtNombreConsultaBusquedaElimar.Text;
            cbonombrebuscar.Text = transfiere;
            txtTablaConsulta.Text = transfiere;
            groupBox2.Enabled = true;
            tbpBE.Hide();
            tbpEditar.Show();
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
            txtTablaConsulta.Text = cbonombrebuscar.SelectedItem.ToString();
            groupBox2.Enabled = true;
        }

        private void cboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String tablabusqueda;
            //tablabusqueda = cboTablaConsultaSimple.Text;
            //CargarColumnas(tablabusqueda, comboBox11);
            tablabusqueda = cboTabla.Text;
            //label37.Text = tablabusqueda;

            //tablabusqueda = cboTabla.SelectedValue.ToString();
            
                CargarColumnas(tablabusqueda, cboCamposEDITAR);
            
            
                
            
        }

        private void cboCamposEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTablaConsultaSimple_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String tablabusqueda;
            //tablabusqueda = cboTablaConsultaSimple.Text;
            //CargarColumnas(tablabusqueda, comboBox11);
            tablabusqueda = cboTablaConsultaSimple.Text;
            label36.Text = tablabusqueda;

            //tablabusqueda = cboTabla.SelectedValue.ToString();

            CargarColumnas(tablabusqueda, cboCamposEDITAR);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbpEditar_Click(object sender, EventArgs e)
        {
           
        }

        private void tbpCreacion_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void cboTabla_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cboTabla_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox11_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTabla_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String tablabusqueda;
            tablabusqueda = cboTablaConsultaSimple.Text;

            CargarColumnas(tablabusqueda, comboBox11);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {

        }

        private void cboCampoConsultaComplejaEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCampoEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTablaConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarAgruparOrdenarEDITAR_Click(object sender, EventArgs e)
        {
            cboAgruparEditar.ResetText();
            cboCampoAgruparEditar.ResetText();
        }

        private void btnCancelarCONSULTACOMPLEJAEDITAR_Click(object sender, EventArgs e)
        {
            cboOperadorLogicoEDITAR.ResetText();
            cboCampoConsultaComplejaEditar.ResetText();
            cbocompand.ResetText();
            txtvalorConsultaComplejaEDITAR.Clear();
        }

        private void txtcancelarComparacionEDITAR_Click(object sender, EventArgs e)
        {
            cboTipoComparadorEditar.ResetText();
            cboCampoEditar.ResetText();
            cbocompwhere.ResetText();
            txtValorComparacionEDITAR.Clear();
        }

        private void btnCancelarCONSULTASIMPLE_Click(object sender, EventArgs e)
        {
            txtcamposelectoseditar.Clear();
            cboTablaConsultaSimple.ResetText();
            cboCamposEDITAR.ResetText();
            txtNombreAlias.Clear();
            txtTablaConsulta.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtcamposelectoseditar.Clear();
            cboTablaConsultaSimple.ResetText();
            cboCamposEDITAR.ResetText();
            txtNombreAlias.Clear();
            txtTablaConsulta.Clear();

            cboOperadorLogicoEDITAR.ResetText();
            cboCampoConsultaComplejaEditar.ResetText();
            cbocompand.ResetText();
            txtvalorConsultaComplejaEDITAR.Clear();
            cboTipoComparadorEditar.ResetText();
            cboCampoEditar.ResetText();
            cbocompwhere.ResetText();
            txtValorComparacionEDITAR.Clear();
            cboAgruparEditar.ResetText();
            cboCampoAgruparEditar.ResetText();
            txtCadenaGeneradaEDITAR.Clear();
        }
    }
    }
    



