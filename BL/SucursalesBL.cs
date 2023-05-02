using DAL;
using ET;
using System.Data;
//using System.Data.SqlClient
namespace BL
{
    public class SucursalesBL
    {
        private SucursalesDAL dal = new SucursalesDAL();
        public bool IngresarSucursal(Sucursales sucursal)
        {
            //Valor de retorno
            bool retVal = true;
            //Instancia una datatable que se llena con los datos existentes en BD 
            DataTable listaSucursales = dal.BuscarTodoSucursal();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaSucursales.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaSucursales.Rows[i]["ID"].ToString();
                if (sucursal.Equals(descripcion))
                    retVal = false;
            }
            //si el valor de retorno es true permite ingresar la categoria debido a que no existe
            if (retVal)
                retVal = dal.IngresarSucursal(sucursal);
            return retVal;
        }

        public bool ActualizarSucursal(Sucursales sucursal)
        {
            bool retVal = false;
            //Busca todos las sucursales disponibles en la BD
            DataTable listaSucursales = dal.BuscarTodoSucursal();
            string descripcion = "";
            //recorre la base de datos hasta encontrar la sucursal a actualizar
            for (int i = 0; i < listaSucursales.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es true
                descripcion = listaSucursales.Rows[i]["ID"].ToString();
                if (sucursal.Equals(descripcion))
                    retVal = true;
            }
            /*si la sucursal ha sido encontrada se ejecuta un metodo en DAL, sino solo retorna falso*/
            if (retVal)
                retVal = dal.ActualizarSucursal(sucursal);
            return retVal;
        }

        public bool BorrarSucursal(int id)
        {
            bool retVal = false;
            DataTable listaSucursales = dal.BuscarTodoSucursal();
            string descripcion = "";
            for (int i = 0; i < listaSucursales.Rows.Count; i++)
            {
                descripcion = listaSucursales.Rows[i][id].ToString();
                if (id.Equals(descripcion))
                    retVal = true;
            }
            if (retVal)
                retVal = dal.BorrarSucursal(id);
            return retVal;
        }

        /*Los metodos tipo DataTable solo van a retornar una instancia a los metodos
        correspondientes de dal ya que,
        no necesita confirmar existencia, solo mostrarla*/
        public DataTable BuscarTodoSucursal()
        {
            return dal.BuscarTodoSucursal();
        }

        public DataTable BuscarSucursal(string ubicacion)
        {
            return dal.BuscarSucursal(ubicacion);
        }
    }
}
