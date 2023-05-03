using DAL;
using ET;
using System.Data;
namespace BL
{
    public class DetalleCategoriaBL
    {
         /*
          * !!! FIXME !!!
          * Validar producto != editorial
          */

        //genera una instancia que permite acceder a los métodos de DetalleCategoriaDAL
        private DetalleCategoriaDAL dal = new DetalleCategoriaDAL();
        private CategoriaDAL det = new CategoriaDAL();
        public bool IngresarListaDetalles(List<DetalleCategoria> ListaCategorias)
        {
            //Valor de retorno 
            bool retVal = true;
            // Instancia una datatable que se llena con los datos existentes en BD 
            DataTable listaDetalles = det.BuscarTodoCategoria();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaDetalles.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaDetalles.Rows[i]["ID"].ToString();
                if (ListaCategorias.Equals(descripcion))
                    retVal = false;
            }
            if (retVal)
                retVal = dal.IngresarDetallesCategoria(ListaCategorias);
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
