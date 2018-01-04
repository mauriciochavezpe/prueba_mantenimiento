using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Dclientes
    {
        private int Id_;
        private string Nombre_;
        private string Apellido_;
        private string Doc_;
        private string Telefono_;
        private string Correo_;


        public int Id
        {
            get { return Id_ ; }
            set { Id_ = value; }
        }

        public string Nombre

        {
            get { return Nombre_; }
            set { Nombre_ = value; }

        }
        public string Apellidos
        {
            get { return Apellido_; }
            set { Apellido_ = value; }

        }
        public string Doc
        {
            get { return Doc_; }
            set { Doc_ = value; }
        }

        public string Telefono

        {
            get { return Telefono_; }
            set { Telefono_ = value; }
        }
        public string Correo
        {
            get { return Correo_; }
            set { Correo_ = value; }
        }

        public Dclientes()
        {

        }
        public Dclientes(int xid , string xnom, string xap, string xdoc, string xtelf , string xcorr)
        {
            Dclientes obj = new Dclientes();
            obj.Id = xid;
            obj.Nombre = xnom;
            obj.Apellidos = xap;
            obj.Doc = xdoc;
            obj.Telefono = xtelf;
            obj.Correo = xcorr;

        }
        public string insertar(Dclientes clientes)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();
            

            try
            {
                sqlcon.ConnectionString = claseconexion.cnn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
               
                sqlcmd.CommandText = "insertar";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@id";
                parid.SqlDbType = SqlDbType.Int;
                parid.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parid);

                SqlParameter parnom = new SqlParameter();
                parnom.ParameterName = "@nombre";
                parnom.SqlDbType = SqlDbType.VarChar;
                parnom.Size = 20;
                parnom.Value = clientes.Nombre;
                sqlcmd.Parameters.Add(parnom);

                SqlParameter parapll = new SqlParameter();
                parapll.ParameterName = "@apell";
                parapll.SqlDbType = SqlDbType.VarChar;
                parapll.Size = 20;
                parapll.Value = clientes.Apellidos;
                sqlcmd.Parameters.Add(parapll);


                SqlParameter pardoc = new SqlParameter();
                pardoc.ParameterName = "@doc";
                pardoc.SqlDbType = SqlDbType.VarChar;
                pardoc.Size = 8;
                pardoc.Value = clientes.Doc;
                sqlcmd.Parameters.Add(pardoc);

                SqlParameter partelf = new SqlParameter();
                partelf.ParameterName = "@telefono";
                partelf.SqlDbType = SqlDbType.VarChar;
                partelf.Size = 9;
                partelf.Value = clientes.Telefono;
                sqlcmd.Parameters.Add(partelf);

                SqlParameter parcorr = new SqlParameter();
                parcorr.ParameterName = "@correo";
                parcorr.SqlDbType = SqlDbType.VarChar;
                parcorr.Size = 20;
                parcorr.Value = clientes.Correo;
                sqlcmd.Parameters.Add(parcorr);

               rpta= sqlcmd.ExecuteNonQuery()== 1? "ok" :"no se inserto nada " ;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
                   
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();

            }

            return rpta;
            
        }

        public string editar(Dclientes clientes)
        {
            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = claseconexion.cnn;

            try
            {

                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "editar";
    
                sqlcmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@id";
                parid.SqlDbType = SqlDbType.Int;
                parid.Value =clientes.Id;
                sqlcmd.Parameters.Add(parid);

                SqlParameter parnom = new SqlParameter();
                parnom.ParameterName = "@nombre";
                parnom.SqlDbType = SqlDbType.VarChar;
                parnom.Size = 20;
                parnom.Value = clientes.Nombre;
                sqlcmd.Parameters.Add(parnom);

                SqlParameter parapll = new SqlParameter();
                parapll.ParameterName = "@apell";
                parapll.SqlDbType = SqlDbType.VarChar;
                parapll.Size = 20;
                parapll.Value = clientes.Apellidos;
                sqlcmd.Parameters.Add(parapll);


                SqlParameter pardoc = new SqlParameter();
                pardoc.ParameterName = "@doc";
                pardoc.SqlDbType = SqlDbType.VarChar;
                pardoc.Size = 8;
                pardoc.Value = clientes.Doc;
                sqlcmd.Parameters.Add(pardoc);

                SqlParameter partelf = new SqlParameter();
                partelf.ParameterName = "@telefono";
                partelf.SqlDbType = SqlDbType.VarChar;
                partelf.Size = 9;
                partelf.Value = clientes.Telefono;
                sqlcmd.Parameters.Add(partelf);

                SqlParameter parcorr = new SqlParameter();
                parcorr.ParameterName = "@correo";
                parcorr.SqlDbType = SqlDbType.VarChar;
                parcorr.Size = 20;
                parcorr.Value = clientes.Correo;
                sqlcmd.Parameters.Add(parcorr);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "no se edito nada ";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();

            }

            return rpta;
                                }
        public string eliminar(Dclientes clientes)
        {

            string rpta = "";

            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = claseconexion.cnn;

            try
            {

                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "eliminar";
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@id";
                parid.SqlDbType = SqlDbType.Int;
                parid.Value = clientes.Id;
                sqlcmd.Parameters.Add(parid);

             

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "no se elimino nada ";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();

            }

            return rpta;

        }
        public DataTable mostrar()
        {
            //instancio a una tabla 
            DataTable dtresultado = new DataTable("clientes");
            SqlConnection sqlcon = new SqlConnection();
      try
            {
                sqlcon.ConnectionString = claseconexion.cnn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "mostrar";
                sqlcmd.CommandType = CommandType.StoredProcedure;
         


            //hago instancia de un adaptador 

            SqlDataAdapter sqltaco = new SqlDataAdapter(sqlcmd);
            sqltaco.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            return dtresultado;
        }
        public DataTable buscar(Dclientes clientes)
        {
            DataTable dtresultado = new DataTable("clientes");
            SqlConnection sqlcon = new SqlConnection();
                        
            try
            {
                sqlcon.ConnectionString = claseconexion.cnn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "buscar";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parid = new SqlParameter();
                parid.ParameterName = "@id";
                parid.SqlDbType = SqlDbType.Int;
                parid.Value = clientes.Id;
                sqlcmd.Parameters.Add(parid);


                //instancia al adaptador entre el sist y la bd 

                SqlDataAdapter sqltaco = new SqlDataAdapter(sqlcmd);
                sqltaco.Fill(dtresultado);

                            }
            catch
            {
                dtresultado = null;
            }
            return dtresultado;
        }
    }
}
