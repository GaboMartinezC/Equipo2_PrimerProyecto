using ET;
using DAL;
using System.Data;
namespace BL
{
    public class EmpleadoBL
    {
        EmpleadoDAL dal = new EmpleadoDAL();
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
                //falso y por lo tanto se sale del ciclo
                if (dt.Rows[i]["CEDULA"].ToString().Equals(empleado.Cedula))
                    return false;
            }
            return dal.IngresarEmpleado(empleado);
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
            //Si es válido, actualiza el registro
            if (retVal)
                retVal = dal.ActualizarEmpleado(empleado);
            return retVal;
        }
        public void InhabilitarEmpleado(int id)
        {
            dal.InhabilitarEmpleado(id);
        }
        public uint BuscarEmpleado(string cedula, string contrasena)
        {
            return dal.BuscarEmpleado(cedula, contrasena);
        }
        public DataTable BuscarTodos()
        {
            return dal.BuscarTodos();
        }
    }
}