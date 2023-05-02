<<<<<<< HEAD
﻿using ET;
using DAL;
using System.Data;

=======
﻿using DAL;
using ET;
using System.Data;
//using System.Data.SqlClient
>>>>>>> 22ec82dd7793dd24a6b9793f9f1b21ffd209a172
namespace BL
{
    public class LibroBL : ProductoBL
    {
<<<<<<< HEAD
        private LibroDAL dal = new LibroDAL();
        public bool IngresarLibro(Libro libro)
        {
            //Valor de retorno
            bool retVal = true,
            //Variable bandera que define si el proveedor del libro es una editorial
            //ver metodo protegido en la superclase producto de la que esta hereda
            esEditorial = ProveedorEsEditorial(libro.IdProveedor);
            //Si el proveedor del libro no es una editorial o si el stock
            //máximo del libro es menor al mínimo, retorna un falso
            if (!esEditorial || libro.StockMaximo < libro.StockMinimo) 
                retVal = false;
            //Si no, el valor de retorno es lo que retorne el método de ingreso
            else
                retVal = dal.IngresarLibro(libro);
            return retVal;
        }
        public bool ActualizarLibro(Libro libro)
        {
            //Ver comentarios del método anterior para más información
            bool retVal = true,
            esEditorial = ProveedorEsEditorial(libro.IdProveedor);
            if (!esEditorial || libro.StockMaximo < libro.StockMinimo)
                retVal = false;
            else
                retVal = dal.ActualizarLibro(libro);
            return retVal;
        }
        public DataTable BuscarLibroIdioma(int idIdi)
        {
            return dal.BuscarLibroIdioma(idIdi);
        }
        public DataTable BuscarLibroAutor(int idAut)
        {
            return dal.BuscarLibroAutor(idAut);
        }
=======
        //genera una instancia que permite acceder a los métodos de LibroDAL
        private LibroDAL dal = new LibroDAL();
        //genera una instancia que permite acceder a los métodos de ProductoDAL
        private ProductoDAL producto = new ProductoDAL();
>>>>>>> 22ec82dd7793dd24a6b9793f9f1b21ffd209a172

        public bool IngresarLibro(Libro libro)
        {
            //Valor de retorno
            bool retVal = true;
            //Instancia una datatable que se llena con los datos existentes en BD 
            DataTable listaLibros = producto.BuscarTodoProductoGeneral();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaLibros.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaLibros.Rows[i]["DESCRIPCION"].ToString();
                if (libro.Equals(descripcion))
                    retVal = false;
            }
            //si el valor de retorno es true permite ingresar la categoria debido a que no existe
            if (retVal)
                retVal = dal.IngresarLibro(libro);
            return retVal;

        }
        public bool ActualizarLibro(Libro libro)
        {
            bool retVal = false;
            //Busca todos las sucursales disponibles en la BD
            DataTable listaProveedores = producto.BuscarTodoProductoGeneral();
            string descripcion = "";
            //recorre la base de datos hasta encontrar la sucursal a actualizar
            for (int i = 0; i < listaProveedores.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es true
                descripcion = listaProveedores.Rows[i]["DESCRIPCION"].ToString();
                if (libro.Equals(descripcion))
                    retVal = true;
            }
            /*si la sucursal ha sido encontrada se ejecuta un metodo en DAL, sino solo retorna falso*/
            if (retVal)
                retVal = dal.ActualizarLibro(libro);
            return retVal;

        }

        //metodos DataTable que van a realizar una busqueda
        public DataTable BuscarLibroIdioma(int idIdi)
        {
            return BuscarLibroIdioma(idIdi);
        }
        public DataTable BuscarLibroAutor(int idAuto)
        {
            return BuscarLibroIdioma(idAuto);
        }
    }
}
