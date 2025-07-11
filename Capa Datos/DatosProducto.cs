using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public abstract class DatosProducto // Aqui Aplicamos El principio abierto y cerrado, abierto para la extencion y cerrado para la modificacion
    {
        private string cSku;
        private string cNombre;
        private string cNombreExtranjero;
        private string cCodGrupoProducto;
        private decimal nPeso;
        private string cUM;
        private decimal nPrecioLista;
        private string cCodBarra;
        private string cSkuAlternante;

        private int idCodFabricante;
        private int idGrupoProducto;
        private int idProveedor;

        public string CSku
        {
            get => cSku; set => cSku = value;

        }
        public string CNombre
        {
            get => cNombre; set => cNombre = value;
        }

        public decimal NPeso
        {
            get => nPeso; set => nPeso = value;
        }
          public string CUM
        {
            get => cUM; set => cUM = value;
        }

        public decimal NPrecioLista
        {
            get => nPrecioLista; set => nPrecioLista = value;
        }

        public string CCodBarra
        {
            get => cCodBarra; set => cCodBarra = value;
        }
        public string CSkuAlternante
        {
            get => cSkuAlternante; set => cSkuAlternante = value;
        }

        public int IdCodFabricante
        {
            get => idCodFabricante; set => idCodFabricante = value;
        }
        public int IdGrupoProducto
        {
            get => idGrupoProducto; set => idGrupoProducto = value;

        }
        public int IdProveedor
        {
            get => idProveedor;set => idProveedor = value;
        }
        private Array GetSkuAlternante (string cSkuBase)
        {
            string[] aSkuAlternate = { "", "" };
            return aSkuAlternate;
        }

        public abstract string obtenerClasificacionProducto();

        public abstract void crearSkuAlternateProducto(string cSkuBase);

        public abstract void crearSkuBase();

        public void RegistrarProducto()
        {
            SqlCommand cmd = null;
            SqlTransaction myTrans = null;
            IBasesDeDatos Conexion = new DatosConexionSqlServer(); // principio de inversion de dependencia
            SqlConnection cnx = Conexion.conectar();
            try
            {
                cnx.Open();
                myTrans = cnx.BeginTransaction();

                string sql = "Insert into producto(Sku,Nombre,Peso,UM,PrecioLista,CodBarra,SkuAlternate,idFabricante,idProveedor,idGrupoProducto) " +
                    "values(@Sku,@Nombre,@Peso,@UM,@PrecioLista,@CodBarra,@SkuAlternate,@idFabrica,@idProveedor,@idGrupoProducto)";
                cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@Sku", cSku);
                cmd.Parameters.AddWithValue("@Nombre", cNombre);
                cmd.Parameters.AddWithValue("@Peso", nPeso);
                cmd.Parameters.AddWithValue("@UM", cUM);
                cmd.Parameters.AddWithValue("@PrecioLista", nPrecioLista);
                cmd.Parameters.AddWithValue("@CodBarra", cCodBarra);
                cmd.Parameters.AddWithValue("@SkuAlternate", cSkuAlternante);
                cmd.Parameters.AddWithValue("@idFabrica", idCodFabricante);
                cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                cmd.Parameters.AddWithValue("@idGrupoProducto", idGrupoProducto);
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
