using DAL;
using ET;
using System.Data;

namespace BL
{
    public class IdiomaBL
    {
        private IdiomaDAL dal = new IdiomaDAL();
        public bool IngresarIdioma(Idioma idioma)
        {
            //Valor de retorno
            bool retVal = true;
            //Busca todos los idiomas disponibles en BD
            DataTable listaIdiomas = dal.BuscarTodoIdioma();
            //Variable temporal que guarda las descripciones de idioma
            //Funciones únicamente de legibilidad, puede ser omitida
            string descripcion = "";
            //Lleva toda la descripcion de idioma a minúsculas
            idioma.Descripcion = idioma.Descripcion.ToLower();
            //recorre la base de datos en busca de la descripción de idioma
            for (int i = 0; i < listaIdiomas.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaIdiomas.Rows[i]["DESCRIPCION"].ToString();
                if (idioma.Descripcion.Equals(descripcion))
                    retVal = false;
            }
            /*Si no se encontró, lo que significaría que el valor de retorno es verdadero
            registra el dato, si no solo retorna el falso*/
            if (retVal)
                retVal = dal.IngresarIdioma(idioma);
            return retVal;
        }
        public bool ActualizarIdioma(Idioma idioma)
        {
            //Valor de retorno
            bool retVal = false;
            //Busca todos los idiomas disponibles en BD
            DataTable listaIdiomas = dal.BuscarTodoIdioma();
            //Variable temporal que guarda las descripciones de idioma
            string descripcion = "";
            //Lleva toda la descripcion de idioma a minúsculas
            idioma.Descripcion = idioma.Descripcion.ToLower();
            //recorre la base de datos en busca de la descripción de idioma
            for (int i = 0; i < listaIdiomas.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaIdiomas.Rows[i]["DESCRIPCION"].ToString();
                if (idioma.Descripcion.Equals(descripcion))
                    retVal = true;
            }
            /*Si se encontró, lo que significaría que el valor de retorno es verdadero
            llama a dal, si no, solo retorna true*/
            if (retVal)
                retVal = dal.ActualizarIdioma(idioma);
            return retVal; 
        }
        public bool BorrarIdioma(int id)
        {
            //Valor de retorno
            bool retVal = false;
            // Instancia una datatable que se llena con los datos existentes en BD de los autores
            DataTable listaIdiomas = dal.BuscarTodoIdioma();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaIdiomas.Rows.Count; i++)
            {
                //recorrido a la lista de idiomas para encontrar el id ingresado
                descripcion = listaIdiomas.Rows[i][id].ToString();
                if (id.Equals(descripcion))
                {
                    retVal = true;
                }
            }
            //si el idioma existe el valor es true por lo que permite borrarlo
            //de no ser encontrado no se podrá borrar algo inexistente por lo que solo retornará false
            if (retVal)
                retVal = dal.BorrarIdioma(id);
            return retVal;
        }
        public DataTable BuscarTodoIdioma() 
        {
            return dal.BuscarTodoIdioma();
        }
    }
}
