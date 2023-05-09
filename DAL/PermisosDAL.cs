using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class PermisosDAL : ConnectionToSQL
    {
        public bool IngresarPermisos(List<Permisos> ListaPermisos)
        {
            bool retVal = false;
            /*
             * Gabriel J.
             * Recibe una lista con todos los permisos de un rol de usuario
             * Los va ingresando a la base de datos con un foreach de cada objeto en la lista
             */
            foreach (Permisos p in ListaPermisos)
            {
                using (var cn = GetConnection())
                {
                    try
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand("SpIngresarPermisos", cn))
                        {
                            cmd.Connection = cn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            /*
                             * Parámetros
                             * Convierte de uint (Unsigned Integer) a Int para BD
                             * metodo Convert.ToInt32() [32 bits, entero estándar]
                             * Gabriel J.
                             */
                            cmd.Parameters.Add(new SqlParameter("@rol", Convert.ToInt32(p.IdRol)));
                            cmd.Parameters.Add(new SqlParameter("@idMod", Convert.ToInt32(p.IdModulo)));
                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Close();
                            retVal = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        retVal = false;
                    }
                }
            }
            return retVal;
        }
        public bool ActualizarPermisos(List<Permisos> ListaPermisos)
        {
            bool retVal = false;
            /*
             * Gabriel J.
             * Recibe una lista con todos los permisos de un rol de usuario
             * Los va ingresando a la base de datos con un foreach de cada objeto en la lista
             */
            foreach (Permisos p in ListaPermisos)
            {
                using (var cn = GetConnection())
                {
                    try
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand("SpActualizarPermisos", cn))
                        {
                            cmd.Connection = cn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            /*
                             * Parámetros
                             * Convierte de uint (Unsigned Integer) a Int para BD
                             * metodo Convert.ToInt32() [32 bits, entero estándar]
                             * Gabriel J.
                             */
                            cmd.Parameters.Add(new SqlParameter("@rol", Convert.ToInt32(p.IdRol)));
                            cmd.Parameters.Add(new SqlParameter("@idMod", Convert.ToInt32(p.IdModulo)));
                            cmd.Parameters.Add(new SqlParameter("@idPerm", Convert.ToInt32(p.Id)));
                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Close();
                            retVal = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        retVal = false;
                    }
                }
            }
            return retVal;
        }
        public bool BorrarPermiso(int id)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBorrarPermisos", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idPerm", id));
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        retVal = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    retVal = false;
                }
            }
            return retVal;
        }
        //Busca los modulos asociados a un rol de usuario
        public bool[] BuscarPermisoRol(int idRol)
        {

            bool[] retVal = new bool[6];
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarPermisosRol", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Parámetros que indican de manera booleana si un rol de usuario tiene permiso de acceder a un modulo
                        SqlParameter perMod1 = new SqlParameter("@permisoMod1", SqlDbType.Bit);
                        SqlParameter perMod2 = new SqlParameter("@permisoMod2", SqlDbType.Bit);
                        SqlParameter perMod3 = new SqlParameter("@permisoMod3", SqlDbType.Bit);
                        SqlParameter perMod4 = new SqlParameter("@permisoMod4", SqlDbType.Bit);
                        SqlParameter perMod5 = new SqlParameter("@permisoMod5", SqlDbType.Bit);
                        SqlParameter perMod6 = new SqlParameter("@permisoMod6", SqlDbType.Bit);
                        //Se indica que son parámetros de salida
                        perMod1.Direction = ParameterDirection.Output;
                        perMod2.Direction = ParameterDirection.Output;
                        perMod3.Direction = ParameterDirection.Output;
                        perMod4.Direction = ParameterDirection.Output;
                        perMod5.Direction = ParameterDirection.Output;
                        perMod6.Direction = ParameterDirection.Output;
                        //ID del rol a evaluar
                        cmd.Parameters.Add(new SqlParameter("@idRol", idRol));
                        //Añade los parámetros
                        cmd.Parameters.Add(perMod1);
                        cmd.Parameters.Add(perMod2);
                        cmd.Parameters.Add(perMod3);
                        cmd.Parameters.Add(perMod4);
                        cmd.Parameters.Add(perMod5);
                        cmd.Parameters.Add(perMod6);
                        SqlDataReader reader = cmd.ExecuteReader();
                        //Convierte los parámetros de salida al arreglo booleano
                        retVal[0] = Convert.ToBoolean(perMod1.Value);
                        retVal[1] = Convert.ToBoolean(perMod2.Value);
                        retVal[2] = Convert.ToBoolean(perMod3.Value);
                        retVal[3] = Convert.ToBoolean(perMod4.Value);
                        retVal[4] = Convert.ToBoolean(perMod5.Value);
                        retVal[5] = Convert.ToBoolean(perMod6.Value);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }
        
    }
}

