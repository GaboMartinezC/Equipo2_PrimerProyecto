using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class EncabezadoEntradaDAL : ConnectionToSQL
    {
        public bool IngresarEntrada(EncabezadoEntrada encabezado)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpIngresarEncabezado", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        /*
                         * Parámetros
                         * Convierte de uint (Unsigned Integer) a Int para BD
                         * metodo Convert.ToInt32() [32 bits, entero estándar]
                         * Gabriel J. 
                         */
                        cmd.Parameters.Add(new SqlParameter("@idSuc", Convert.ToInt32(encabezado.IdSucursal)));
                        cmd.Parameters.Add(new SqlParameter("@idEmp", Convert.ToInt32(encabezado.IdEmpleado)));
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
    }
}
