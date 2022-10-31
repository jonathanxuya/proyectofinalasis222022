using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_ModeloContabilidad;

namespace Capa_ControladorContabilidad
{
   public class controlador
    {
        Sentencias sn=new Sentencias();

        public void llenarcombo( string tabla, ComboBox combo, int posicion)
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

        public bool cierreGAct(string p, string cuenta, float monto, string fecha)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierreAct (pkid_cierreA,cuenta_nombre,monto_total,fecha_cierre)VALUE(?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_cierreA", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@cuenta_nombre", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@monto_total", OdbcType.Double).Value = monto;
                    cmd.Parameters.Add("@fecha_cierre", OdbcType.Date).Value = fecha;
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

        public bool CierreGeneral(string p, float totA, float totP, string cod, string name, string fecha)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierregeneral (pkid_cierreG,total_activo,total_pasivo,codigo_contador,nombre_contador,fecha_cierre)VALUE(?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_cierreG", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@total_activo", OdbcType.Double).Value = totA;
                    cmd.Parameters.Add("@total_pasivo", OdbcType.Double).Value = totP;
                    cmd.Parameters.Add("@codigo_contador", OdbcType.VarChar).Value = cod;
                    cmd.Parameters.Add("@nombre_contador", OdbcType.VarChar).Value = name;
                    cmd.Parameters.Add("@fecha_cierre", OdbcType.Date).Value = fecha;
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

        public bool cierreGPas(string p, string cuenta, float monto, string fecha)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierrePas (pkid_cierreP,cuenta_nombre,monto_total,fecha_cierre)VALUE(?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_cierreP", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@cuenta_nombre", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@monto_total", OdbcType.Double).Value = monto;
                    cmd.Parameters.Add("@fecha_cierre", OdbcType.Date).Value = fecha;
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

        public DataTable ctas(DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
            String cadena = "";
            try
            { 
                con.Open();
                cadena = "SELECT nombre_cuenta FROM  tbl_cuentas" ;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {

            }
            return dt;
        }

        public bool confcierre(string p, string cuenta, float totp, float totac, string cod, string name, string fec)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_confctascierrre (pkid_confcierre,cuenta_nombre,total_activo,total_pasivo,codigo_contador,nombre_contador,fecha_cierre)VALUE(?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_confcierre", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@cuenta_nombre", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@total_activo", OdbcType.Double).Value = totac;
                    cmd.Parameters.Add("@total_pasivo", OdbcType.Double).Value = totp;
                    cmd.Parameters.Add("@codigo_contador", OdbcType.VarChar).Value = cod;
                    cmd.Parameters.Add("@nombre_contador", OdbcType.VarChar).Value = name;
                    cmd.Parameters.Add("@fecha_cierre", OdbcType.Date).Value = fec;
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

        public bool guardarcta(string razon, float monto, string fecha, string cuenta, string p)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierrectasact (pkid_ctaAct,nombre_cuenta,razon,monto,fecha)VALUE(?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_ctaAct", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@nombre_cuenta", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@razon", OdbcType.VarChar).Value = razon;
                    cmd.Parameters.Add("@monto", OdbcType.Double).Value = monto;
                    cmd.Parameters.Add("@fecha", OdbcType.Date).Value = fecha;
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

        public bool guardarctaP(string p, string razon, float monto, string cuenta, string fecha)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierrectaspas (pkid_ctaPas,nombre_cuenta,razon,monto,fecha)VALUE(?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_ctaPas", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@nombre_cuenta", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@razon", OdbcType.VarChar).Value = razon;
                    cmd.Parameters.Add("@monto", OdbcType.Double).Value = monto;
                    cmd.Parameters.Add("@fecha", OdbcType.Date).Value = fecha;
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
    }
}
