using DAL;
using ET;
using System.Data;
//using System.Data.SqlClient
namespace BL
{
    public class BodegaBL
    {
        private BodegaDAL dal = new BodegaDAL();

        public bool IngresarBodega(Bodega bodega)
        {
            //Valor de retorno
            bool retVal = true;
            //Instancia una datatable que se llena con los datos existentes en BD 
            DataTable listaBodegas = dal.VerInventario();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaBodegas.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaBodegas.Rows[i]["ID"].ToString();
                if (bodega.Equals(descripcion))
                    retVal = false;
            }
            //si el valor de retorno es true permite ingresar la categoria debido a que no existe
            if (retVal)
                retVal = dal.IngresarBodega(bodega);
            return retVal;

        }
        public bool AumentarInventario(Bodega bodega)
        {
            //Valor de retorno
            bool retVal = false;

            //Instancia una datatable que se llena con los datos existentes en BD 
            DataTable listaBodegas = dal.VerInventario();
            //Variable temporal que guarda los datos a validar
            string descripcion = "";
            for (int i = 0; i < listaBodegas.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es verdadero
                descripcion = listaBodegas.Rows[i]["IDPRODUCTO"].ToString();
                if (bodega.Equals(descripcion))
                    retVal = true;
            }
            //si el valor de retorno es true permite ingresar la categoria debido a que no existe
            if (retVal)
                retVal = dal.AumentarInventario(bodega);
            return retVal;
        }

        //metodos tipo DataTable que invoca a los metodos en dal para realizar una busqueda en la BD
        public DataTable VerInventario()
        {
            return dal.VerInventario();
        }
        public DataTable BuscarProductoSucursal(Bodega bodega)
        {
            return dal.BuscarProductoSucursal(bodega);
        }
        public DataTable VerBodega(int idSuc)
        {
            return dal.VerBodega(idSuc);
        }
    }
}
