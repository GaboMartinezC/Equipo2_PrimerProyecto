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
        private DetalleEntradaBL bl = new DetalleEntradaBL();
        public bool IngresarEntrada(EncabezadoEntrada encabezado, List<DetalleEntrada> listaDetalle)
        {
            //Si no encuentra excepciones en encabezado y detalles devuelve verdadero y sale del metodo
            if (dal.IngresarEntrada(encabezado)) 
            {
                if (detalleDal.IngresarDetalleEntrada(listaDetalle))
                    return true;
            }
            return false;
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
