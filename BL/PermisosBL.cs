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
        public bool IngresarPermisos(List<Permisos> ListaPermisos)
        {
            return dal.IngresarPermisos(ListaPermisos);

        }
        public bool ActualizarPermisos(List<Permisos> ListaPermisos)
        {
            return dal.ActualizarPermisos(ListaPermisos);
        }
        /*Los metodos tipo DataTable solo van a retornar una instancia a los metodos
        correspondientes de dal ya que, no necesita confirmar existencia, solo mostrarla*/
        public bool[] BuscarPermisoRol(int idRol)
        {
            return dal.BuscarPermisoRol(idRol);
        }
        public bool BorrarPermiso(int id)
        {
            return dal.BorrarPermiso(id);
        }

        
    }
}
