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
        public uint IngresarDetalleEntrada(List<DetalleEntrada> ListaDetalles, uint idSuc)
        {
            //Variables bandera que alojarán las cantidades máximas y mínimas, más la nueva cantidad
            uint cantidadesMaximasProducto = 0, cantidadesMinimasProducto = 0,
            nuevaCantidad = 0, cantActual = 0, cantidadErrores = 0;
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
                        //Instancia una entidad bodega y se llena con los datos requeridos del objeto en lista
                        Bodega bodega = new Bodega();
                        bodega.IdProducto = de.IdProducto;
                        bodega.IdSucursal = idSuc;
                        //Convierte los registros actuales del recorrido de la datatable que se 
                        //requieran procesar a unsigned int
                        cantidadesMaximasProducto = Convert.ToUInt32(dtProducto.Rows[i]["STOCK_MAXIMO"]);
                        cantidadesMinimasProducto = Convert.ToUInt32(dtProducto.Rows[i]["STOCK_MINIMO"]);
                        //Llama al SP de busqueda para verificar que hayan productos de esa clase en la bodega
                        cantActual = bodegaDal.BuscarProductoSucursal(bodega).Cantidad;
                        //nueva cantidad es igual a la cantidad existente del producto en la sucursal
                        //más la cantidad ingresada
                        nuevaCantidad = cantActual + de.Cantidad;
                        //Si se cumple la condición, cuenta como fallida la operacion de ingresar la entrada
                        if (nuevaCantidad < cantidadesMinimasProducto || nuevaCantidad > cantidadesMaximasProducto)
                            cantidadErrores++;
                        else
                        {
                            bodega.Cantidad = nuevaCantidad;
                            //Si ya hay productos, aumenta inventario
                            if (cantActual != 0)
                                bodegaDal.AumentarInventario(bodega);
                            //Si no hay productos, ingresa bodega
                            else
                                bodegaDal.IngresarBodega(bodega);
                            //Registra el detalle de entrada
                            detalleDal.IngresarDetalleEntrada(de);
                            break;
                        }
                    }
                }
            }
            //Retorna la cantidad de errores de ingreso por stock
            return cantidadErrores;
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
