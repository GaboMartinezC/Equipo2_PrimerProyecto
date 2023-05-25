using DAL;
using ET;
using System.Data;
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
            string telef = "";
            for (int i = 0; i < listaSucursales.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                telef = listaSucursales.Rows[i]["NUMERO_TELEFONICO"].ToString();
                if (sucursal.NumeroTelefonico.Equals(telef))
                    retVal = false;
            }
            //si el valor de retorno es true permite ingresar la categoria debido a que no existe
            if (retVal)
                retVal = dal.IngresarSucursal(sucursal);
            return retVal;
        }

        public bool ActualizarSucursal(Sucursales sucursal)
        {
            bool retVal = true;
            //Cuenta los registros que se encontraron, no debe pasar de uno
            //que es el que se irá a actualizar
            int cantRegistros = 0;
            //Busca todos las sucursales disponibles en la BD
            DataTable listaSucursales = dal.BuscarTodoSucursal();
            string telef = "";
            //recorre la base de datos hasta encontrar la sucursal a actualizar
            for (int i = 0; i < listaSucursales.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es true
                telef = listaSucursales.Rows[i]["NUMERO_TELEFONICO"].ToString();
                if (sucursal.NumeroTelefonico.Equals(telef))
                    cantRegistros++;
                if (cantRegistros > 1)
                {
                    retVal = false;
                    break;
                }
            }
            //Si se encuentra solo un registro, actualiza el registro
            if (cantRegistros <= 1)
                retVal = dal.ActualizarSucursal(sucursal);
            return retVal;
        }

        public bool BorrarSucursal(int id)
        {
            return dal.BorrarSucursal(id);
        }
        /*Los metodos tipo DataTable solo van a retornar una instancia a los metodos
        correspondientes de dal ya que,
        no necesita confirmar existencia, solo mostrarla*/
        public DataTable BuscarTodoSucursal()
        {
            return dal.BuscarTodoSucursal();
        }

        
    }
}
