using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaNegocios
{
    public class NegocioCategoria
    {

        //Obtener categoria
        public static DataTable ObtenerCategoria()
        {
            return new Categorias().obtenerCategoria();
        }

        //Actualizar Categoria

        public static string NegActualizar(int codigo, string descripcion)
        {
            Categorias cate = new Categorias();
            cate.CodCategoria = codigo;
            cate.Descripcion = descripcion;
            return cate.ActualizarCategoria(cate);
        }
        //Insertar Categorias
        public static string InsertCategoria(string descripcion)
        {
            Categorias cate = new Categorias();
            cate.Descripcion = descripcion;
            return cate.InsertarCategoria(cate);
        }
        /*Eliminar Categoria
        public static string EliminarCategoria(int codigo)
        {
            Categorias cate = new Categorias();
            cate.CodCategoria = codigo;
            return cate.EliminarCategoria(cate);
        }*/
    }
}
