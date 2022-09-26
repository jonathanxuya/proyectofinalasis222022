using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_ModeloConsultas;
using System.Data.Odbc;
using System.Data;

namespace Capa_ControladorConsultas
{
    public class clscontrolador
    {
        Sentencias sn = new Sentencias();
        public DataTable llenartb1(string tabla)
        {
            OdbcDataAdapter dt = sn.llenartb1(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public OdbcDataReader llenarcbo()
        {
            string sql = "show full tables from hotelsancarlos;";
            return sn.llenarcbotabla(sql);
        }
        public OdbcDataReader llenarcbo2(string tabla)
        {
            string sql = "show columns from " + tabla + ";";
            return sn.llenarcbotabla(sql);
        }
        public OdbcDataReader llenarcboq(string tabla)
        {
            string sql = "select nombre, consulta from " + tabla + ";";
            return sn.llenarcbotabla(sql);
        }
        public void ingresarconsulta(string nombre, string consulta)
        {
            string sql = "insert into registro_consultas (nombre,consulta) values ( '" + nombre + "', '" + consulta + "') ;";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
        public OdbcDataReader llenarinsert(string sql)
        {
            return sn.validarconsulta(sql);
        }
        public DataTable llenartb2()
        {
            string consulta = "select * from registro_consultas";
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable llenartb3(string condicion)
        {
            string consulta = "select * from registro_consultas where nombre= " + '"' + condicion + '"';
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void ejecutarconsulta(string condicion)
        {
            string sql = "DELETE FROM registro_consultas where nombre = " + '"' + condicion + '"' + ";";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
        public OdbcDataReader llenarcbonombreconsulta()
        {
            string sql = "select nombre from registro_consultas;";
            return sn.llenarcbotabla(sql);
        }
        public void editarconsulta(string nombre, string consulta)
        {
            string sql = "update registro_consultas set consulta ='" + consulta + "'" + "where nombre = '" + nombre + "' ;";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }
        OdbcConnection con = new OdbcConnection("FIL=MS Acces;DSN=Colchoneria");
        public bool InsertBusqueda(string _nomb, string _cons, string _area, string _camp)
        {
            using (con)
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;

                #region Query
                String query = @"INSERT INTO consultainteligente(Nombre,Tabla,Campos,Alias) VALUE(?,?,?,?);";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@Nombre", OdbcType.Int).Value = _nomb;
                cmd.Parameters.Add("@Tabla", OdbcType.VarChar).Value = _cons;
                cmd.Parameters.Add("@Campos", OdbcType.VarChar).Value = _area;
                cmd.Parameters.Add("@Alias", OdbcType.VarChar).Value = _camp;

              //  cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public bool InsertBusquedaCompleja(string _ope, string _camp, string _valo)
        {
            
            using (con)
            {
                OdbcCommand cmda = new OdbcCommand();
                con.Open();
                cmda.Connection = con;

                #region Query
                

               String query = @"INSERT INTO consultainteligente1 (operador,campos,valor) VALUE(?,?,?);";
                
                #endregion
                cmda.CommandType = CommandType.Text;
                cmda.CommandText = query;
                cmda.Parameters.Add("@operador", OdbcType.Int).Value = _ope;
                cmda.Parameters.Add("@campos", OdbcType.VarChar).Value = _camp;
                cmda.Parameters.Add("@valor", OdbcType.VarChar).Value = _valo;


                cmda.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public bool InsertBusquedaCompleja1(string _ope, string _camp)
        {
            using (con)
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;

                #region Query
                String query = @"INSERT INTO consultainteligente2 (ordenar,campo) VALUE(?,?);";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@ordenar", OdbcType.Int).Value = _ope;
                cmd.Parameters.Add("@campo", OdbcType.VarChar).Value = _camp;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
    }
}

