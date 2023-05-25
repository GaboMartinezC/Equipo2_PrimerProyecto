using DAL;
using ET;
using System.Data;
//using System.Data.SqlClient
namespace BL
{
    public class EncabezadoEntradaBL
    {
        //genera una instancia que permite acceder a los métodos de EncabezadoEntradaDAL
        private EncabezadoEntradaDAL dal = new EncabezadoEntradaDAL();
        private DetalleEntradaDAL detalleDal = new DetalleEntradaDAL();
        public bool IngresarEntrada(EncabezadoEntrada encabezado)
        {
            return dal.IngresarEntrada(encabezado);
        }
        public bool BorrarRegistroEntrada(int idEncabezado)
        {
            return dal.BorrarRegistroEntrada(idEncabezado);
        }
        public bool ActualizarEntrada(EncabezadoEntrada entrada)
        {
            return dal.ActualizarEntrada(entrada);

        }
        /*
         * Los metodos tipo DataTable solo van a retornar una instancia a los metodos 
         * correspondientes de dal ya que, 
         * no necesita confirmar existencia, solo mostrarla
         */
        public DataTable VerTodoRegistroEntradas()
        {
            return detalleDal.VerTodoRegistroEntradas();
        }
        
    }
}
