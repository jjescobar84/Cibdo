using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaNegocios
{
    public class NegProductos
    {
        
        //Mostrar los productos
        public static DataTable ObtenerProductosConNomCat()
        {
            return new Productos().obtenerProductos();
        }

        //Actualizar Productos

        public static string ActualizarProduct(string nombre, decimal precio)
        {
            Productos proc = new Productos();
            proc.NombreProducto = nombre;
            proc.PrecioUnit = precio;
            return proc.ActualizarProductos(proc);
        }

        //Insertra productos
        public static string InsertProductos(string nombreProducto, decimal precioUnit, int categoria)
        {
            Productos proc = new Productos();
            proc.NombreProducto = nombreProducto;
            proc.PrecioUnit = precioUnit;
            proc.CatProducto = categoria;
            return proc.InsertarProductos(proc);
        }

        //Eliminar Productos
        public static string EliminarProductos(int codigo)
        {
            Productos proc = new Productos();
            proc.CodProducto = codigo;
            return proc.EliminarProductos(proc);
        }
    }
}
