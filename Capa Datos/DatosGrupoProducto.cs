using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class DatosGrupoProducto
    {

        private string cNmbProveedor;

        public string CNmbProveedor
        {
            get => cNmbProveedor; set => cNmbProveedor = value;

        }

        public void RegistrarGrupoProducto()
        {
            SqlCommand cmd = null;
            SqlTransaction myTrans = null;
            IBasesDeDatos Conexion = new DatosConexionSqlServer();
            SqlConnection cnx = Conexion.conectar();
            try
            {
                cnx.Open();
                myTrans = cnx.BeginTransaction();

                string sql = "Insert into GrupoProducto (NombreGrupoProducto) values(@NombreGrupoProducto)";
                cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@NombreGrupoProducto", cNmbProveedor);
                cmd.Transaction = myTrans;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                myTrans.Rollback();

            }
            myTrans.Commit();
            cnx.Close();
           
        }
    }
}
