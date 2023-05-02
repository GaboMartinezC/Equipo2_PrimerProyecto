<<<<<<< HEAD
﻿using ET;
using DAL;
using System.Data;

=======
﻿using DAL;
using ET;
using System.Data;
//using System.Data.SqlClient
>>>>>>> 22ec82dd7793dd24a6b9793f9f1b21ffd209a172
namespace BL
{
    public class DetalleEntradaBL
    {
<<<<<<< HEAD
        private DetalleEntradaDAL dal = new DetalleEntradaDAL();
=======
        //genera una instancia que permite acceder a los métodos de EncabezadoEntradaDAL
        private EncabezadoEntradaDAL dal = new EncabezadoEntradaDAL();
        //genera una instancia que permite acceder a los métodos de DetalleEntradaDAL
        private DetalleEntradaDAL det = new DetalleEntradaDAL();

>>>>>>> 22ec82dd7793dd24a6b9793f9f1b21ffd209a172
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
                        DataTable dtBusquedaProdSuc = bodegaDAL.BuscarProductoSucursal(bodega);
                        //nueva cantidad es igual a la cantidad existente del producto en la sucursal
                        //más la cantidad ingresada
                        nuevaCantidad = Convert.ToUInt32(dtBusquedaProdSuc.Rows[0]["CANTIDAD"]) + de.Cantidad;
                        //Si se cumple la condición, retorna un falso y sale del método
                        if (nuevaCantidad < cantidadesMinimasProducto || nuevaCantidad > cantidadesMaximasProducto)
                            return false;
                        else
                            de.Cantidad = nuevaCantidad;
                        break;
                    }
                }
            }
            //Si no encontró ningún problema y no salió del método, ingresa la lista
<<<<<<< HEAD
            return dal.IngresarDetalleEntrada(ListaDetalles);
        }
        public DataTable VerTodoRegistroEntradas()
        {
            return dal.VerTodoRegistroEntradas();
        }
=======
            return det.IngresarDetalleEntrada(ListaDetalles);
        }
        public bool ActualizarDetalleEntrada(List<DetalleEntrada> ListaDetalles)
        {
            bool retVal = false;
            // Instancia una datatable que se llena con los datos existentes en BD 
            DataTable listaEntradas = dal.VerTodoRegistroEntradas();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaEntradas.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaEntradas.Rows[i]["ID"].ToString();
                if (ListaDetalles.Equals(descripcion))
                    retVal = true;
            }
            if (retVal)
                retVal = det.ActualizarDetalleEntrada(ListaDetalles);
            return retVal;
        }

        public DataTable UltimoIdEncabezado()
        {
            return UltimoIdEncabezado();
        }


>>>>>>> 22ec82dd7793dd24a6b9793f9f1b21ffd209a172
    }
}
