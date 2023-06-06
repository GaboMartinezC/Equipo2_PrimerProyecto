﻿using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class BodegaDAL : ConnectionToSQL
    {
        public bool IngresarBodega(Bodega bodega)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpIngresarBodega", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        /*
                         * Parámetros
                         * Convierte de uint (Unsigned Integer) a Int para BD
                         * metodo Convert.ToInt32() [32 bits, entero estándar]
                         * Gabriel J.
                         */
                        cmd.Parameters.Add(new SqlParameter("@idProd", Convert.ToInt32(bodega.IdProducto)));
                        cmd.Parameters.Add(new SqlParameter("@idSuc", Convert.ToInt32(bodega.IdSucursal)));
                        cmd.Parameters.Add(new SqlParameter("@cant", Convert.ToInt32(bodega.Cantidad)));
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
        /*
         * Funciona como un Update, sin embargo solo reescribe la cantidad de producto que hay
         * Puede ser utilizado para disminuir inventario también
        */
        public bool AumentarInventario(Bodega bodega)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpAumentarInventario", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        /*
                         * Parámetros
                         * Convierte de uint (Unsigned Integer) a Int para BD
                         * metodo Convert.ToInt32() [32 bits, entero estándar]
                         * Gabriel J.
                         */
                        cmd.Parameters.Add(new SqlParameter("@idProd", Convert.ToInt32(bodega.IdProducto)));
                        cmd.Parameters.Add(new SqlParameter("@idSuc", Convert.ToInt32(bodega.IdSucursal)));
                        cmd.Parameters.Add(new SqlParameter("@cant", Convert.ToInt32(bodega.Cantidad)));
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
        //Muestra todo el inventario de todas las sucursales
        public DataTable VerInventario()
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("VerInventario", cn))
                    {
                        cmd.Connection = cn;
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
        //Busca un producto específico en una sucursal específica
        
        
    }
}
