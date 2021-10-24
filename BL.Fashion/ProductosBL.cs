using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace BL.Fashion
{
    public class ProductosBL
    {
        contexto _contexto;

        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new contexto();
            ListaProductos = new BindingList<Producto>();

           }

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }


        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty (producto.Descripcion) == true)
            {
                resultado.Mensaje = "Debe registrar una 'Descripción'.";
                resultado.Exitoso = false;
            }

            if (producto.Precio <= 0)
            {
                resultado.Mensaje = "El Precio debe ser mayor que cero.";
                resultado.Exitoso = false;
            }

            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La Existencia debe ser mayor o igual a cero.";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty (producto.TipoProducto) == true)
            {
                resultado.Mensaje = "Debe registrar un 'Tipo de Producto'.";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public string TipoProducto { get; set; }
        public bool Activo { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

}
