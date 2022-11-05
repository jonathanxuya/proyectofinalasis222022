using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Capa_ModeloContabilidad;

namespace Capa_ControladorContabilidad
{
   public class controlador
    {
            Sentencias sn = new Sentencias();

            public void llenarcombo(string tabla, ComboBox combo, int posicion)
            {

                try
                {

                    OdbcDataAdapter dt = sn.llenarcomboproducto(tabla);
                    DataTable table = new DataTable();
                    dt.Fill(table);

                    int contador = 0;
                    combo.Items.Clear();

                    foreach (DataRow row in table.Rows)
                    {

                        combo.Items.Add(table.Rows[contador][posicion].ToString());
                        contador++;
                    }

                }
                catch (Exception e)
                {
                MessageBox.Show(" " + e);
            }
            }

        public bool InsertProducto(string _Pk, string _Edi, string _Mue, string _Equi, string _Maqui, string _Herra, string _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_activosfijos (pk_ActivosFijos,Edificaiones,Muebles,Equipos,Maquinaria,Herramientas,EquipoComputo)VALUE(?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_ActivosFijos", OdbcType.Int).Value = _Pk;
                    cmd.Parameters.Add("@Edificaiones", OdbcType.VarChar).Value = _Edi;
                    cmd.Parameters.Add("@Muebles", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@Equipos", OdbcType.VarChar).Value = _Equi;
                    cmd.Parameters.Add("@Maquinaria", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@Herramientas", OdbcType.VarChar).Value = _Herra;
                    cmd.Parameters.Add("@EquipoComputo", OdbcType.VarChar).Value = _Eqco;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool UpdateProducto(string _Pk, string _Edi, string _Mue, string _Equi, string _Maqui, string _Herra, string _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE tbl_activosfijos SET tbl_activosfijos.Edificaiones = ?, tbl_activosfijos.Muebles = ?, tbl_activosfijos.Equipos = ?, tbl_activosfijos.Maquinaria = ? , tbl_activosfijos.Herramientas = ? , tbl_activosfijos.EquipoComputo = ? WHERE tbl_activosfijos.pk_ActivosFijos = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.Add("@Edificaiones", OdbcType.VarChar).Value = _Edi;
                    cmd.Parameters.Add("@Muebles", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@Equipos", OdbcType.VarChar).Value = _Equi;
                    cmd.Parameters.Add("@Maquinaria", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@Herramientas", OdbcType.VarChar).Value = _Herra;
                    cmd.Parameters.Add("@EquipoComputo", OdbcType.VarChar).Value = _Eqco;
                    cmd.Parameters.Add("@pk_ActivosFijos", OdbcType.Int).Value = _Pk;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteProducto(string _Pk)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_activosfijos WHERE tbl_activosfijos.pk_ActivosFijos = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_ActivosFijos", OdbcType.VarChar).Value = _Pk;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable SelectProducto()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_activosfijos;", "FIL=MS Access;DSN=colchoneria"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarDato(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_activosfijos WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }

        public DataTable ActualizarT(string table, DataTable dt)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
                String cadena = "";
                con.Open();
                cadena = "SELECT * FROM " + table;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {
                String textalert = " Error al actualizar datos, puede que no haya datos que mostrar ";
                MessageBox.Show(textalert);
            }
            return dt;
        }

        //Jonathan Xuyá

        public bool InsertEF(float _Pk, float _Edi, float _Mue, float _Equi, float _Maqui, float _Herra, float _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_EstadosFinancieros (Pk_EstadosFinancieros,ActivoCirculante,ActivoNoCirculante,PasivoACortoPlazo,PasivoALargoPlazo,CapitalContable,ResultadoAPeriodo)VALUE(?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@Pk_EstadosFinancieros", OdbcType.Double).Value = _Pk;
                    cmd.Parameters.Add("@ActivoCirculante", OdbcType.Double).Value = _Edi;
                    cmd.Parameters.Add("@ActivoNoCirculante", OdbcType.Double).Value = _Mue;
                    cmd.Parameters.Add("@PasivoACortoPlazo", OdbcType.Double).Value = _Equi;
                    cmd.Parameters.Add("@PasivoALargoPlazo", OdbcType.Double).Value = _Maqui;
                    cmd.Parameters.Add("@CapitalContable", OdbcType.Double).Value = _Herra;
                    cmd.Parameters.Add("@ResultadoAPeriodo", OdbcType.Double).Value = _Eqco;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable data(DataTable dt, string v)
        {
            OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria");
            con.Open();
            string cadena;
            cadena = "Select" + v + " from tbl_cierregeneral";
            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
            datos.Fill(dt);
            con.Close();
            return (dt);

        }

        public bool UpdateEF(float _Pk, float _Edi, float _Mue, float _Equi, float _Maqui, float _Herra, float _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE tbl_EstadosFinancieros SET tbl_EstadosFinancieros.ActivoCirculante = ?, tbl_EstadosFinancieros.ActivoNoCirculante = ?, tbl_EstadosFinancieros.PasivoACortoPlazo = ?, tbl_EstadosFinancieros.PasivoALargoPlazo = ? , tbl_EstadosFinancieros.CapitalContable = ? , tbl_EstadosFinancieros.ResultadoAPeriodo = ? WHERE tbl_EstadosFinancieros.Pk_EstadosFinancieros = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;


                    cmd.Parameters.Add("@ActivoCirculante", OdbcType.Double).Value = _Edi;
                    cmd.Parameters.Add("@ActivoNoCirculante", OdbcType.Double).Value = _Mue;
                    cmd.Parameters.Add("@PasivoACortoPlazo", OdbcType.Double).Value = _Equi;
                    cmd.Parameters.Add("@PasivoALargoPlazo", OdbcType.Double).Value = _Maqui;
                    cmd.Parameters.Add("@CapitalContable", OdbcType.Double).Value = _Herra;
                    cmd.Parameters.Add("@ResultadoAPeriodo", OdbcType.Double).Value = _Eqco;
                    cmd.Parameters.Add("@Pk_EstadosFinancieros", OdbcType.Double).Value = _Pk;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteEF(float _Pk)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_activosfijos WHERE tbl_activosfijos.pk_ActivosFijos = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@tbl_EstadosFinancieros", OdbcType.VarChar).Value = _Pk;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable SelectEF()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_EstadosFinancieros;", "FIL=MS Access;DSN=colchoneria"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarEF(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_EstadosFinancieros WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }

        public DataTable ActualizarEF(string table, DataTable dt)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
                String cadena = "";
                con.Open();
                cadena = "SELECT * FROM " + table;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {
                String textalert = " Error al actualizar datos, puede que no haya datos que mostrar ";
                MessageBox.Show(textalert);
            }
            return dt;
        }

    }
}
