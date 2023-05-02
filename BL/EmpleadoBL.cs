using ET;
using DAL;
using System.Data;
namespace BL
{
    public class EmpleadoBL
    {
        EmpleadoDAL dal = new EmpleadoDAL();
<<<<<<< HEAD
=======
        public bool IngresarEmpleado(Empleado empleado)
        {
            //Valor de retorno
            bool retVal = true;
            //Llena una datatable con todos los registros
            DataTable dt = dal.BuscarTodos();
            //Recorre la datatable en busqueda de este empleado
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Si las cédulas coinciden en alguna de las instancias, el valor de retorno
                //es falso y por lo tanto se sale del ciclo
                if (dt.Rows[i]["CEDULA"].ToString().Equals(empleado.Cedula))
                    return false;
            }
            //Si no se encontró, llama a consultar los datos de contacto
            retVal = ContactosUsuarioValidos(empleado);
            if (retVal)
                retVal = dal.IngresarEmpleado(empleado);
            return retVal;
        }
        public bool ActualizarEmpleado(Empleado empleado)
        {
            bool retVal = true;
            int cantRegistros = 0;
            //Llena una datatable con todos los registros
            DataTable dt = dal.BuscarTodos();
            //Recorre la datatable en busqueda de este empleado
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Si lo encuentra, aumenta el contador
                if (dt.Rows[i]["CEDULA"].ToString().Equals(empleado.Cedula))
                {
                    cantRegistros++;
                    //Si de por sí ya es mayor a uno, para evitar recorridos innecesarios
                    //sale del metodo
                    if (cantRegistros > 1)
                        return false;
                }
            }
            //Valida si el registro es igual a 1, por lo cual solo existe en la BD el registro 
            //que se va a modificar
            if (cantRegistros == 1)
                retVal = ContactosUsuarioValidos(empleado);
            else
                retVal = dal.ActualizarEmpleado(empleado);
            return retVal;
        }
        public void InhabilitarEmpleado(int id)
        {
            dal.InhabilitarEmpleado(id);
        }
        private bool ContactosUsuarioValidos(Empleado empleado)
        {
            bool retVal = true;
            int cantArroba = 0;
            //Convierte el email del empleado en una arreglo de caracteres
            char[] email = empleado.Email.ToCharArray();
            //Recorre el arreglo
            for (int i = 0; i <= email.Length; i++)
            {
                //Busca arrobas en el email
                if (email[i] == '@')
                    cantArroba++;
            }
            //Si encuentra más de una o no encuentra, devuelve un falso
            if (cantArroba != 1)
                retVal = false;
            //Valida el que siga sin encontrar ninguna anomalía
            if (retVal)
            {
                //Finalmente, recorre el numero telefonico del empleado
                foreach (char c in empleado.NumeroTelefonico)
                {
                    //Si existe algún elemento que no sea un numero, devuelve falso y sale del ciclo
                    if (!(c >= '0' && c <= '9'))
                    {
                        retVal = false;
                        break;
                    }
                }
            }
            return retVal;
        }
>>>>>>> 22ec82dd7793dd24a6b9793f9f1b21ffd209a172
        public uint BuscarEmpleado(string cedula, string contrasena)
        {
            return dal.BuscarEmpleado(cedula, contrasena);
        }
    }
}
