using ET;
using DAL;
using System.Data;
namespace BL
{
    public class DetalleEntradaBL
    {
        private DetalleEntradaDAL detalleDal = new DetalleEntradaDAL();
        private BodegaDAL bodegaDal = new BodegaDAL();
        //genera una instancia que permite acceder a los métodos de DetalleEntradaDAL
        private DetalleEntradaDAL det = new DetalleEntradaDAL();
        public bool IngresarDetalleEntrada(List<DetalleEntrada> ListaDetalles, uint idSuc)
        {
            //Variables bandera que alojarán las cantidades máximas y mínimas, más la nueva cantidad
            uint cantidadesMaximasProducto = 0, cantidadesMinimasProducto = 0, nuevaCantidad = 0;
            //Instancia del DAL de producto y una datatable con
            //un listado de productos generales
            ProductoDAL pDal = new ProductoDAL();
            DataTable dtProducto = pDal.BuscarTodoProductoGeneral();
            //Instancia de un DAL de Bodega, para acceder al metodo
            //de busqueda de producto en una sucursal
            BodegaDAL bodegaDAL = new BodegaDAL();
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
                        //Instancia una entidad bodega y se llena con los datos requeridos del objeto en lista
                        Bodega bodega = new Bodega();
                        bodega.IdProducto = de.IdProducto;
                        bodega.IdSucursal = idSuc;
                        //Convierte los registros actuales del recorrido de la datatable que se 
                        //requieran procesar a unsigned int
                        cantidadesMaximasProducto = Convert.ToUInt32(dtProducto.Rows[i]["STOCK_MAXIMO"]);
                        cantidadesMinimasProducto = Convert.ToUInt32(dtProducto.Rows[i]["STOCK_MINIMO"]);
                        //Llama al SP de busqueda 
                        //nueva cantidad es igual a la cantidad existente del producto en la sucursal
                        //más la cantidad ingresada
                        nuevaCantidad = bodegaDAL.BuscarProductoSucursal(bodega).Cantidad + de.Cantidad;
                        //Si se cumple la condición, retorna un falso y sale del método
                        if (nuevaCantidad < cantidadesMinimasProducto || nuevaCantidad > cantidadesMaximasProducto)
                            return false;
                        else
                        {
                            bodega.Cantidad = nuevaCantidad;
                            bodegaDal.AumentarInventario(bodega);
                        }
                            
                        break;
                    }
                }
            }
            //Si no encontró ningún problema y no salió del método, ingresa la lista
            return detalleDal.IngresarDetalleEntrada(ListaDetalles);
        }
        public DataTable VerTodoRegistroEntradas()
        {
            return detalleDal.VerTodoRegistroEntradas();
        }
    }
}
