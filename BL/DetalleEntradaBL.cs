using ET;
using DAL;
using System.Data;
namespace BL
{
    public class DetalleEntradaBL
    {
        //genera una instancia que permite acceder a los métodos de DetalleEntradaDAL
        private DetalleEntradaDAL detalleDal = new DetalleEntradaDAL();
        //genera una instancia que permite acceder a los métodos de BodegaDAL
        private BodegaDAL bodegaDal = new BodegaDAL();
        public bool ValidarDetalleEntrada(List<DetalleEntrada> ListaDetalles, uint idSuc)
        {
            //Variables bandera que alojarán las cantidades máximas y mínimas, más la nueva cantidad
            uint stockMax = 0, stockMin = 0, nuevaCantidad = 0;
            //Instancia del DAL de producto y una datatable con
            //un listado de productos generales
            ProductoDAL pDal = new ProductoDAL();
            DataTable dtProducto = pDal.BuscarTodoProductoGeneral();
            //Recorre el listado de productos
            for (int i = 0; i < dtProducto.Rows.Count; i++)
            {
                //Anidado al recorrido del listado de productos, un recorrido
                //del listado de detalles de entrada en busqueda de ID's semejantes
                foreach (DetalleEntrada de in ListaDetalles)
                {
                    //Si se encuentran semejanzas, compara que se logre llenar
                    //el stock mínimo y no sobrepase el stock máximo, después finaliza el ciclo
                    if (de.IdProducto == Convert.ToUInt32(dtProducto.Rows[i]["ID"]))
                    {
                        //Instancia un objeto bodega y lo llena con los datos para validar la cantidad
                        Bodega bodega = new Bodega();
                        bodega.IdProducto = de.IdProducto;
                        bodega.IdSucursal = idSuc;
                        nuevaCantidad = BuscarProductoSucursal(bodega) + de.Cantidad;
                        stockMax = Convert.ToUInt32(dtProducto.Rows[i]["STOCK_MAXIMO"]);
                        stockMin = Convert.ToUInt32(dtProducto.Rows[i]["STOCK_MINIMO"]);
                        //Valida el stock máximo y mínimo
                        if (nuevaCantidad > stockMax || nuevaCantidad < stockMin)
                            return false;
                    }
                }
            }
            //Retorna verdadero si no encontró errores
            return true;
        }
        //Busca la cantidad de producto que existe en una sucursal
        public uint BuscarProductoSucursal(Bodega bodega)
        {
            //Llena una datatable con el inventario
            DataTable listaBodegas = bodegaDal.VerInventario();
            //variables que alojan datos temporales, solo funcionan para legibilidad de codigo
            uint idProd = 0, idSuc = 0;
            //recorre la datatable
            for (int i = 0; i < listaBodegas.Rows.Count; i++)
            {
                //llena las variables con los datos del registro consultado
                idProd = Convert.ToUInt32(listaBodegas.Rows[i]["ID_PRODUCTO"].ToString());
                idSuc = Convert.ToUInt32(listaBodegas.Rows[i]["ID_SUCURSAL"].ToString());
                //si hay coincidencias, retorna la cantidad
                if (idProd == bodega.IdProducto && idSuc == bodega.IdSucursal)
                    return Convert.ToUInt32(listaBodegas.Rows[i]["CANTIDAD"].ToString());
            }
            //si no encuentra nada, retorna un 0
            return 0;
        }
        public DataTable VerTodoRegistroEntradas()
        {
            return detalleDal.VerTodoRegistroEntradas();
        }
    }
}
