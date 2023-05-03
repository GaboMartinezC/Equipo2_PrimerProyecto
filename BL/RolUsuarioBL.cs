using DAL;
using ET;
using System.Data;
//using System.Data.SqlClient
namespace BL
{
    public class RolUsuarioBL
    {
        private RolUsuarioDAL dal = new RolUsuarioDAL();
        public bool IngresarRolUsuario(RolUsuario rolUsuario)
        {
            //Valor de retorno
            bool retVal = true;
            //Instancia una datatable que se  llena con los datos existentes en BD 
            DataTable listaRolUsuarios = dal.BuscarTodos();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaRolUsuarios.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaRolUsuarios.Rows[i]["DESCRIPCION"].ToString();
                if (rolUsuario.Equals(descripcion))
                    retVal = false;
            }
            //si el valor de retorno es true permite ingresar la categoria debido a que no existe
            if (retVal)
                retVal = dal.IngresarRolUsuario(rolUsuario);
            return retVal;
        }

        public bool ActualizarRolUsuario(RolUsuario rolUsuario)
        {
            bool retVal = false;
            //Busca todos las sucursales disponibles en la BD
            DataTable listaRolUsuarios = dal.BuscarTodos();
            string descripcion = "";
            //recorre la base de datos hasta encontrar la sucursal a actualizar
            for (int i = 0; i < listaRolUsuarios.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es true
                descripcion = listaRolUsuarios.Rows[i]["DESCRIPCION"].ToString();
                if (rolUsuario.Equals(descripcion))
                    retVal = true;
            }
            //si la sucursal ha sido encontrada se ejecuta un metodo en DAL, sino solo retorna falso
            if (retVal)
                retVal = dal.ActualizarRolUsuario(rolUsuario);
            return retVal;
        }

        public bool BorrarRolUsuario(int id)
        {
            bool retVal = true;
            DataTable listaRolUsuario = dal.BuscarTodos();
            string descripcion = "";
            for (int i = 0; i < listaRolUsuario.Rows.Count; i++)
            {
                descripcion = listaRolUsuario.Rows[i][id].ToString();
                if (id.Equals(descripcion))
                    retVal = true;
            }
            if (retVal)
                retVal = dal.BorrarRolUsuario(id);
            return retVal;
        }

        public DataTable BuscarTodo()
        {
            return dal.BuscarTodos();
        }

        public DataTable BuscarRolUsuario(string descrip)
        {
            return dal.BuscarRolUsuario(descrip);
        }
    }
}
