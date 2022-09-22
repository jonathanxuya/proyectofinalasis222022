using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Controlador;

namespace Capa_Vista
{
   public class Class1
    {
        OdbcConnection con = new OdbcConnection("FIL=MS Acces;DSN=Colchoneria");
        public bool InsertBusqueda(string _nomb, string _cons, string _area, string _camp)
        {
            using (con)
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;

                #region Query
                String query = @"INSERT INTO consultainteligente (pk_Id_Nombre_Consulta,nombre_Consulta,alias,pk_Id_Campo) VALUE(?,?,?,?);";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@pk_Id_Nombre_Consulta", OdbcType.Int).Value = _nomb;
                cmd.Parameters.Add("@nombre_Consulta", OdbcType.VarChar).Value = _cons;
                cmd.Parameters.Add("@alias", OdbcType.VarChar).Value = _area;
                cmd.Parameters.Add("@pk_Id_Campo", OdbcType.VarChar).Value = _camp;

                cmd.ExecuteNonQuery();
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
                String query = @"INSERT INTO busqueda (operador,campos,valor) VALUE(?,?,?);";
                #endregion
                cmda.CommandType = CommandType.Text;
                cmda.CommandText = query;
                cmda.Parameters.Add("@nombre", OdbcType.Int).Value = _ope;
                cmda.Parameters.Add("@nombre", OdbcType.VarChar).Value = _camp;
                cmda.Parameters.Add("@nombre", OdbcType.VarChar).Value = _valo;


                //cmda.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
    }



}