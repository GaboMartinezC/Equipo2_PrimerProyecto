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
            //valor de retorno 
            bool retVal = true;
            DataTable listaBodegas = dal.VerInventario();
            string descripcion = " ";
            int idProd=0;
            int idSuc=0;
            for (int i=0; i < listaBodegas.Rows.Count; i++)
            {
                idProd = Convert.ToInt32(listaBodegas.Rows[i]["ID_PRODUCTO"].ToString());
                idSuc = Convert.ToInt32(listaBodegas.Rows[i]["ID_SUCURSAL"].ToString());
                if (idProd == bodega.IdProducto && idSuc == bodega.IdSucursal)
                    return dal.AumentarInventario(bodega);
            }
            return dal.IngresarBodega(bodega);
        }
        //metodos tipo DataTable que invoca a los metodos en dal para realizar una busqueda en la BD
        public DataTable VerInventario()
        {
            return dal.VerInventario();
        }
        public Bodega BuscarProductoSucursal(Bodega bodega)
        {
            return dal.BuscarProductoSucursal(bodega);
        }
       
    }
}
