using DAL;
using ET;
using System.Data;
//using System.Data.SqlClient
namespace BL
{
    public class PermisosBL
    {
        //genera una instancia que permite acceder a los métodos de PermisosDAL
        private PermisosDAL dal = new PermisosDAL();

        /*Los metodos tipo DataTable solo van a retornar una instancia a los metodos
        correspondientes de dal ya que, no necesita confirmar existencia, solo mostrarla*/
        public DataTable BuscarPermisoRol(int idRol)
        {
            return dal.BuscarPermisoRol(idRol);
        }

        public bool IngresarPermisos(List<Permisos> ListaPermisos, int idRol)
        {
            //Valor de retorno
            bool retVal = true;
            /*Instancia al metodo buscarPermisoRol de usuario,
             al ingresar un permiso se indica el rol al que se desea ser aplicado
            y por medio del id, se realiza la validacion de su existencia en la BD*/
            DataTable listaPermisos = BuscarPermisoRol(idRol); ;
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaPermisos.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaPermisos.Rows[i]["DESCRIPCION"].ToString();
                if (ListaPermisos.Equals(descripcion))
                    retVal = false;
            }
            //si el valor de retorno es true permite ingresar el permiso debido a que no existe
            if (retVal)
                retVal = dal.IngresarPermisos(ListaPermisos);
            return retVal;

        }
        public bool ActualizarPermisos(List<Permisos> ListaPermisos, int idRol)
        {
            bool retVal = false;
            /*Instancia al metodo buscar permiso de rol usuario,
             al ingresar un permiso se indica al rol que se desea ser aplicado
            y por medio del id, se realiza la validacion de su existencia en la BD*/
            DataTable listaPermisos = BuscarPermisoRol(idRol); ;
            string descripcion = "";
            //recorre la base de datos hasta encontrar el permiso a actualizar
            for (int i = 0; i < listaPermisos.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es true
                descripcion = listaPermisos.Rows[i]["DESCRIPCION"].ToString();
                if (ListaPermisos.Equals(descripcion))
                    retVal = true;
            }
            //si el permiso ha sido encontrada se ejecuta un metodo en DAL, sino solo retorna falso
            if (retVal)
                retVal = dal.ActualizarPermisos(ListaPermisos);
            return retVal;

        }
        public bool BorrarPermiso(int id, int idRol)
        {
            bool retVal = false;
            /*Instancia al metodo buscar permiso de rol usuario,
             al ingresar un permiso se indica al rol que se desea ser aplicado
            y por medio del id, se realiza la validacion de su existencia en la BD*/
            DataTable listaPermisos = BuscarPermisoRol(idRol); ;
            string descripcion = "";
            for (int i = 0; i < listaPermisos.Rows.Count; i++)
            {
                descripcion = listaPermisos.Rows[i][id].ToString();
                if (id.Equals(descripcion))
                    retVal = true;
            }
            if (retVal)
                retVal = dal.BorrarPermiso(id);
            return retVal;
        }

        
    }
}
