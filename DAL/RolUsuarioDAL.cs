using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class RolUsuarioDAL : ConnectionToSQL
    {
        public uint IngresarRolUsuario(RolUsuario rol)
        {
            uint retVal = 0;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpIngresarRolUsuario", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@descrip", rol.Descripcion));
                        SqlParameter IdRol = new SqlParameter("@idRol", SqlDbType.Int);
                        IdRol.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(IdRol);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                        if (IdRol.Value != DBNull.Value)
                            retVal = Convert.ToUInt32(IdRol.Value);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    retVal = 0;
                }
            }
            return retVal;
        }
        public bool ActualizarRolUsuario(RolUsuario rol)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpActualizarRolUsuario", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idRol", Convert.ToInt32(rol.Id)));
                        cmd.Parameters.Add(new SqlParameter("@descrip", rol.Descripcion));
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
        public bool BorrarRolUsuario(int id)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBorrarRolUsuario", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idRol", id));
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
        public DataTable BuscarTodos()
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarTodoRolUsuario", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        da.Fill(retVal);
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
