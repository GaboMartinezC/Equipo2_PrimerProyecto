using DAL;
using ET;
using System.Data;
namespace BL
{
    public class BodegaBL
    {
        private BodegaDAL dal = new BodegaDAL();
        public bool IngresarBodega(Bodega bodega)
        {
            return dal.IngresarBodega(bodega);
        }
        //metodos tipo DataTable que invoca a los metodos en dal para realizar una busqueda en la BD
        public DataTable VerInventario()
        {
            return dal.VerInventario();
        }
       
    }
}
