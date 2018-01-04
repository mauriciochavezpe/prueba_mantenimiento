using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using CapaDatos;
namespace CapaNegocio
{
    public class Class1
    {
        public static string insertar(string xnom, string xap, string xdoc, string xtelf , string xcor)

        {
            Dclientes obj = new Dclientes();
            obj.Nombre = xnom;
            obj.Apellidos = xap;
            obj.Doc = xdoc;
            obj.Telefono = xtelf;
            obj.Correo = xcor;
            return obj.insertar(obj);
        }
        public static string editar(int xid , string xnom,string xapl, string xdoc, string xtelf , string xcor)

        {
            Dclientes obj = new Dclientes();
            obj.Id = xid;
            obj.Nombre = xnom;
            obj.Apellidos = xapl;
            obj.Doc = xdoc;
            obj.Telefono = xtelf;
            obj.Correo = xcor;
            return obj.editar(obj);

        }
        public static string eliminar(int xid)
        {
            Dclientes obj = new Dclientes();
            obj.Id = xid;
            return obj.eliminar(obj);
        }
        public static DataTable buscar(int xid)
        { 
            Dclientes obj = new Dclientes();
            obj.Id = xid;
            return obj.buscar(obj);
        }
        public static DataTable mostrar()
        {
        return new Dclientes().mostrar();
        }
    }
}
