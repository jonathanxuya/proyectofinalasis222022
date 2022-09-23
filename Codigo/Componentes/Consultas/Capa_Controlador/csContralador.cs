using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador
{
    public class clsControlador
    {
        Sentencias sn = new Sentencias();

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
}