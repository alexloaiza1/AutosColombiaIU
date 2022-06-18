using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AutosColombia.Controller
{
    public class conexion
    {
        SqlConnection objcon;
        SqlCommand objComando;
        SqlDataAdapter objAdap;
        String comSql;
        String cadConex;

        public conexion()
        {
            //poner un @ antes de la cadena de conexion para eliminar erros y borrar la comillas y espacios

            cadConex = @"Data Source=LAPTOP-FL2BH7DT\MSSQLSERVER01;Initial Catalog=AutosColombia;Integrated Security=True;Pooling=False";
        }

        public SqlConnection Objcon { get => objcon; set => objcon = value; }

        public string abrirBd()
        {
            String msg = "ok";
            try
            {
                objcon = new SqlConnection(cadConex);//instaceamos la clase sqlconnection. se lanza el constructor usando new 
                objcon.Open();

            }
            catch (Exception objExp)
            {
                msg = objExp.Message;
            }
            return msg;

        }
        public string cerrarBd()
        {
            String msg = "ok";
            try
            {

                objcon.Close();

            }
            catch (Exception objExp)
            {
                msg = objExp.Message;
            }
            return msg;

        }
        public string ejecutarComandoSql(string comSql)
        {
            String msg = " ";

            try
            {
                objComando = new SqlCommand(comSql, objcon);
                objComando.ExecuteNonQuery();
                msg = " EXITO ";
            }
            catch (Exception objExp)
            {
                msg = objExp.Message;
                msg = "¡ERROR!  ";
            }
            return msg;

        }
        public DataSet ejecutarConsultaSql(string comSql)
        {
            String msg = "ok";
            DataSet objDset = new DataSet();


            try
            {
                SqlDataAdapter objAdap = new SqlDataAdapter(comSql, objcon);
                objAdap.Fill(objDset);

            }
            catch (Exception objExp)
            {
                msg = objExp.Message;
            }
            return objDset;

        }
    }
}