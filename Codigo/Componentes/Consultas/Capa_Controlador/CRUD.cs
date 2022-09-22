using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador
{
   public class CRUD
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
                String query = @"INSERT INTO consultainteligente (Nombre,Tabla,Campos,Alias) VALUE(?,?,?,?);";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@Nombre", OdbcType.Int).Value = _nomb;
                cmd.Parameters.Add("@Tabla", OdbcType.VarChar).Value = _cons;
                cmd.Parameters.Add("@Campos", OdbcType.VarChar).Value = _area;
                cmd.Parameters.Add("@Alias", OdbcType.VarChar).Value = _camp;

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
                String query = @"INSERT INTO consultainteligente1 (operador,campos,valor) VALUE(?,?,?);";
                #endregion
                cmda.CommandType = CommandType.Text;
                cmda.CommandText = query;
                cmda.Parameters.Add("@nombre", OdbcType.Int).Value = _ope;
                cmda.Parameters.Add("@nombre", OdbcType.VarChar).Value = _camp;
                cmda.Parameters.Add("@nombre", OdbcType.VarChar).Value = _valo;


                cmda.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public bool InsertBusquedaCompleja1(string _ope, string _camp)
        {
            using (con)
            {
                OdbcCommand cmdo = new OdbcCommand();
                con.Open();
                cmdo.Connection = con;

                #region Query
                String query = @"INSERT INTO consultainteligente2 (oredenar,campo) VALUE(?,?);";
                #endregion
                cmdo.CommandType = CommandType.Text;
                cmdo.CommandText = query;
                cmdo.Parameters.Add("@nombre", OdbcType.Int).Value = _ope;
                cmdo.Parameters.Add("@nombre", OdbcType.VarChar).Value = _camp;
                


               // cmdo.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
    }



}
