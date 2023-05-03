using DAL;
using ET;
using System.Data;

namespace BL
{
    public class AutorBL
    {
        private AutorDAL dal = new AutorDAL();
        public bool IngresarAutor(Autor autor)
        {
            //Valor de retorno 
            bool retVal = true;
            /* Instancia una datatable que se llena con los datos existentes en BD */
            DataTable listaAutores = dal.BuscarTodos();
            //Variable temporal que guarda los datos a validar
            //Funciones únicamente de legibilidad, puede ser omitida
            string descripcion = "";
            for(int i = 0; i < listaAutores.Rows.Count; i++) 
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaAutores.Rows[i]["NOMBRE"].ToString();
                //Compara nombre y apellido
                if (autor.Nombre.Equals(descripcion))
                {
                    descripcion = listaAutores.Rows[i]["APELLIDOS"].ToString();
                    if (autor.Apellidos.Equals(descripcion))
                        retVal = false;
                    //Finaliza el ciclo
                    break;
                }
            }
            //Si no se encontró, lo que significaría que el valor de retorno es verdadero
            //registra el dato y retorna el verdadero (a menos que exista una excepción), si no, solo retorna el falso
            if (retVal)
                retVal = dal.IngresarAutor(autor);
            return retVal;
        }

        public bool BorrarAutor(int idAut)
        {
            //Valor de retorno
            bool retVal = false;
            // Instancia una datatable que se llena con los datos existentes en BD de los autores
            DataTable listaAutores = dal.BuscarTodos();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaAutores.Rows.Count; i++)
            {
                //recorrido a la lista de autores
                descripcion = listaAutores.Rows[i][idAut].ToString();
                if(idAut.Equals(descripcion))
                {
                    retVal=true;
                }
            }
            //retorna true en caso de que el id haya sido encontrado para seguidamente borrarlo
            if (retVal)
                retVal= dal.BorrarAutor(idAut);
            return retVal;
        }

        public bool ActualizarAutor(Autor autor)
        {
            bool retVal = false;
            DataTable listaAutores = dal.BuscarTodos();
            string descripcion = "";
            for (int i = 0; i < listaAutores.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaAutores.Rows[i]["NOMBRE"].ToString();
                //Compara nombre y apellido
                if (autor.Nombre.Equals(descripcion))
                    retVal = true;
                descripcion = listaAutores.Rows[i]["APELLIDOS"].ToString();
                if (autor.Apellidos.Equals(descripcion))
                    retVal = true;
            }
            if (retVal)
                retVal = dal.ActualizarAutor(autor);
            return retVal;

        }

        /*Los metodos tipo DataTable solo van a retornar una instancia a los metodos
        correspondientes de dal ya que,
        no necesita confirmar existencia, solo mostrarla*/
        public DataTable BuscarAutorNombre(string nombre) 
        {
            return dal.BuscarAutorApellido(nombre);
        }
        public DataTable BuscarAutorApellido(string apellido)
        {
            return dal.BuscarAutorApellido(apellido);
        }
        public DataTable BuscarTodos()
        {
            return dal.BuscarTodos();
        }

    }
}
