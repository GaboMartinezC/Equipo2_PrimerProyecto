using DAL;
using ET;
using System.Data;
namespace BL
{
    public class DetalleCategoriaBL
    {
        //genera una instancia que permite acceder a los métodos de DetalleCategoriaDAL
        private DetalleCategoriaDAL dal = new DetalleCategoriaDAL();
        
        public bool IngresarListaDetalles(List<DetalleCategoria> ListaCategorias)
        {
            //Valor de retorno 
            bool retVal = true;
            //Instancia los dal de producto y categoria para compararlos
            CategoriaDAL cat = new CategoriaDAL();
            ProductoDAL prod = new ProductoDAL();
            // Instancia una datatable que se llena con las categorias
            DataTable listaCategorias = cat.BuscarTodoCategoria();
            // Instancia una datatable que se llena con los productos
            DataTable listaProductos = prod.BuscarTodoProductoGeneral();
            //Recorre la lista de productos
            for(int i = 0; i < listaProductos.Rows.Count; i++)
            {
                //Para cada producto, extrae en una variable la cantidad de paginas del producto
                //pues esta variable es indicativo en el registro en base de datos de si este es un libro o no
                uint cantPaginasProducto = Convert.ToUInt32(listaProductos.Rows[i]["CANTIDAD_PAGINAS"]);
                //Para cada producto, recorre una vez la lista de categorías
                foreach (DetalleCategoria dc in ListaCategorias)
                {
                    //Si el id es el mismo en producto y en categoria, empieza a recorrer la lista de categoría
                    if (Convert.ToUInt32(listaProductos.Rows[i]["ID"]) == dc.IdProducto)
                    {
                        for (int j = 0; j < listaCategorias.Rows.Count; j++)
                        {
                            //Valida coincidencias en las categorías de la lista y de la tabla 
                            if (Convert.ToUInt32(listaCategorias.Rows[i]["ID"]) == dc.IdCategoria)
                            {
                                //Valida que a un producto no se le asignen generos literarios
                                if (cantPaginasProducto > 0)
                                {
                                    if (Convert.ToBoolean(listaCategorias.Rows[i]["ES_GENERO"]))
                                        return false;
                                }
                                //Valida que a un libro no se le asignen categorias de producto
                                else
                                {
                                    if (!Convert.ToBoolean(listaCategorias.Rows[i]["ES_GENERO"]))
                                        return false;
                                }
                            }
                        }
                    }
                }
            }
            return retVal;
        }
        public bool BorrarDetalle(int id)
        {
            return dal.BorrarDetalle(id);
        }
        public DataTable BuscarCategoriasProducto(int idProd)
        {
            return dal.BuscarCategoriasProducto(idProd);
        }
    }
}
