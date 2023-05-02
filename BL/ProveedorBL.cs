using ET;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class ProveedorBL
    {
        private ProveedorDAL dal = new ProveedorDAL();

        public bool IngresarProveedor(Proveedor proveedor)
        {
            //Valor de retorno
            bool retVal = true;
            //Instancia una datatable que se llena con los datos existentes en BD 
            DataTable listaProveedores = dal.BuscarTodo();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaProveedores.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaProveedores.Rows[i]["DESCRIPCION"].ToString();
                if (proveedor.Equals(descripcion))
                    retVal = false;
            }
            //si el valor de retorno es true permite ingresar la categoria debido a que no existe
            if (retVal)
                retVal = dal.IngresarProveedor(proveedor);
            return retVal;
           
        }
        public bool ActualizarProveedor(Proveedor proveedor)
        {
            bool retVal = false;
            //Busca todos las sucursales disponibles en la BD
            DataTable listaProveedores = dal.BuscarTodo();
            string descripcion = "";
            //recorre la base de datos hasta encontrar la sucursal a actualizar
            for (int i = 0; i < listaProveedores.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es true
                descripcion = listaProveedores.Rows[i]["DESCRIPCION"].ToString();
                if (proveedor.Equals(descripcion))
                    retVal = true;
            }
            /*si la sucursal ha sido encontrada se ejecuta un metodo en DAL, sino solo retorna falso*/
            if (retVal)
                retVal = dal.ActualizarProveedor(proveedor);
            return retVal;
            
        }
        public bool BorrarProveedor(int id)
        {
            bool retVal = false;
            DataTable listaProveedores = dal.BuscarTodo();
            string descripcion = "";
            for (int i = 0; i < listaProveedores.Rows.Count; i++)
            {
                descripcion = listaProveedores.Rows[i][id].ToString();
                if (id.Equals(descripcion))
                    retVal = true;
            }
            if (retVal)
                retVal = dal.BorrarProveedor(id);
            return dal.BorrarProveedor(id);
        }

        /*Los metodos tipo DataTable solo van a retornar una instancia a los metodos
        correspondientes de dal ya que,
        no necesita confirmar existencia, solo mostrarla*/
        public DataTable BuscarTodo()
        {
            return dal.BuscarTodo();
        }
        public DataTable BuscarProveedor(string descrip)
        {
            return dal.BuscarProveedor(descrip);
        }
    }
}
