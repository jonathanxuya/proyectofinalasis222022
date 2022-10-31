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
        public bool Insertpresupuesto(string _Pkp, string _Pkm, string _Pka, string _Pkc, string _NOMB, string _fech, string _des, string _te, string _ant, string _stat)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_presupuesto (PKidpresupuesto,PKidMoneda,PKidArea,PKidCuenta,nombre,fecha,descripcion,monto,anotacion,status)VALUE(?,?,?,?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@PKidpresupuesto", OdbcType.Int).Value = _Pkp;
                    cmd.Parameters.Add("@PKidMoneda", OdbcType.Int).Value = _Pkm;
                    cmd.Parameters.Add("@PKidArea", OdbcType.Int).Value = _Pka;
                    cmd.Parameters.Add("@PKidCuenta", OdbcType.Int).Value = _Pkc;
                    cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = _NOMB;
                    cmd.Parameters.Add("@fecha", OdbcType.VarChar).Value = _fech;
                    cmd.Parameters.Add("@descripcion", OdbcType.VarChar).Value = _des;
                    cmd.Parameters.Add("@monto", OdbcType.VarChar).Value = _te;
                    cmd.Parameters.Add("@anotacion", OdbcType.VarChar).Value = _ant;
                    cmd.Parameters.Add("@status", OdbcType.VarChar).Value = _stat;
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


        public bool Updatepresupuesto(string _Pkp, string _Pkm, string _Pka, string _Pkc, string _NOMB, string _fech, string _des, string _te, string _ant, string _stat)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE tbl_presupuesto SET tbl_presupuesto.PKidMoneda = ?, tbl_presupuesto.PKidArea = ?, tbl_presupuesto.PKidCuenta = ?, tbl_presupuesto.nombre = ? , tbl_presupuesto.fecha = ? , tbl_presupuesto.descripcion = ? , tbl_presupuesto.monto = ? , tbl_presupuesto.anotacion = ? , tbl_presupuesto.status = ? WHERE tbl_presupuesto.PKidpresupuesto = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;


                    cmd.Parameters.Add("@PKidMoneda", OdbcType.Int).Value = _Pkm;
                    cmd.Parameters.Add("@PKidArea", OdbcType.Int).Value = _Pka;
                    cmd.Parameters.Add("@PKidCuenta", OdbcType.Int).Value = _Pkc;
                    cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = _NOMB;
                    cmd.Parameters.Add("@fecha", OdbcType.VarChar).Value = _fech;
                    cmd.Parameters.Add("@descripcion", OdbcType.VarChar).Value = _des;
                    cmd.Parameters.Add("@monto", OdbcType.VarChar).Value = _te;
                    cmd.Parameters.Add("@anotacion", OdbcType.VarChar).Value = _ant;
                    cmd.Parameters.Add("@status", OdbcType.VarChar).Value = _stat;
                    cmd.Parameters.Add("@PKidpresupuesto", OdbcType.Int).Value = _Pkp;

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

        public bool Deletepresupuestos(string _Pk)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_presupuesto WHERE tbl_presupuesto.PKidpresupuesto = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@PKidpresupuesto", OdbcType.VarChar).Value = _Pk;
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

        public DataTable Selectpresupuesto()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_activosfijos;", "FIL=MS Access;DSN=colchoneria"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarDatop(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_presupuesto WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
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

        public DataTable Actualizarp(string table, DataTable dt)
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

        public bool InsertEstado(string _Pk, string _Edi, string _Mue, string _Equi, string _Maqui, string _Herra, string _Eqco)
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
                    cmd.Parameters.Add("@Pk_EstadosFinancieros", OdbcType.Int).Value = _Pk;
                    cmd.Parameters.Add("@ActivoCirculante", OdbcType.VarChar).Value = _Edi;
                    cmd.Parameters.Add("@ActivoNoCirculante", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@PasivoACortoPlazo", OdbcType.VarChar).Value = _Equi;
                    cmd.Parameters.Add("@PasivoALargoPlazo", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@CapitalContable", OdbcType.VarChar).Value = _Herra;
                    cmd.Parameters.Add("@ResultadoAPeriodo", OdbcType.VarChar).Value = _Eqco;
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


        public bool UpdateEstado(string _Pk, string _Edi, string _Mue, string _Equi, string _Maqui, string _Herra, string _Eqco)
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


                    cmd.Parameters.Add("@ActivoCirculante", OdbcType.VarChar).Value = _Edi;
                    cmd.Parameters.Add("@ActivoNoCirculante", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@PasivoACortoPlazo", OdbcType.VarChar).Value = _Equi;
                    cmd.Parameters.Add("@PasivoALargoPlazo", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@CapitalContable", OdbcType.VarChar).Value = _Herra;
                    cmd.Parameters.Add("@ResultadoAPeriodo", OdbcType.VarChar).Value = _Eqco;
                    cmd.Parameters.Add("@Pk_EstadosFinancieros", OdbcType.Int).Value = _Pk;

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

        public bool DeleteEstado(string _Pk)
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

        public DataTable SelectEstado()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_EstadosFinancieros;", "FIL=MS Access;DSN=colchoneria"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarEstado(string data, string col, DataTable dt)
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

        public DataTable ActualizarE(string table, DataTable dt)
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
