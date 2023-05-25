using DAL;
using ET;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class CategoriaBL
    {
        private CategoriaDAL dal = new CategoriaDAL();
        public bool IngresarCategoria(Categoria categoria)
        {
            //Valor de retorno
            bool retVal = true;
            //Instancia una datatable que se llena con los datos existentes en BD 
            DataTable listaCategorias = dal.BuscarTodoCategoria();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaCategorias.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaCategorias.Rows[i]["DESCRIPCION"].ToString();
                //Compara nombre y apellido
                if (categoria.Descripcion.Equals(descripcion))
                {
                    retVal = false;
                    break;
                }
            }
            //si el valor de retorno es true permite ingresar la categoria debido a que no existe
            if (retVal)
                retVal = dal.IngresarCategoria(categoria);
            return retVal;
        }

        public bool ActualizarCategoria(Categoria categoria)
        {
            //Valor de retorno
            bool retVal = false;
            //Cuenta la cantidad de registros iguales, no debe haber más de 1, que es el que se va 
            //a actualizar
            uint cantRegistros = 0;
            //Busca todos los idiomas disponibles en BD
            DataTable listaCategorias = dal.BuscarTodoCategoria();
            //Variable temporal que guarda la descripcione
            string descripcion = "";
            //recorre la base de datos en busca de la descripción 
            for (int i = 0; i < listaCategorias.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaCategorias.Rows[i]["DESCRIPCION"].ToString();
                if (categoria.Descripcion.Equals(descripcion))
                    cantRegistros++;
            }
            /*Si se encontró, lo que significaría que el valor de retorno es verdadero
            llama a dal, si no, solo retorna true*/
            if (cantRegistros > 1)
                retVal = false;
            else
                retVal = dal.ActualizarCategoria(categoria);
            return retVal;
        }

        public bool BorrarCategoria(int idCat)
        {
            return dal.BorrarCategoria(idCat);
        }

        /*Los metodos tipo DataTable solo van a retornar una instancia a los metodos
        correspondientes de dal ya que,
        no necesita confirmar existencia, solo mostrarla*/
        public DataTable BuscarTodoCategoria()
        {
            return dal.BuscarTodoCategoria();
        }
    }
}
