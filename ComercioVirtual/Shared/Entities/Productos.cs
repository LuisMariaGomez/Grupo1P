namespace Shared.Entities
{
    public class Productos : EntityBase
    {  
        public string? Nombre {  get; set; }
        public int IdProveedor {  get; set; }
        public int IdCategoria {  get; set; }
        public int UnidadesProducto {  get; set; }
        public int PrecioProducto {  get; set; }
        public int Stock { get; set; }

        // EF
        //public int ProveedorId { get; set; }
        //public Proveedor Proveedor { get; set; } = null!; // 1:n con Proveedor 


        //public Categoria? Categoria { get; set; }
        //public int CategoriaId { get; set; }    // 1:n con Categoria 

        //public List<OrdenDeCompra> OrdenesDeCompra { get; } = []; // n:n con OrdenDeCompra
        //public ICollection<OrdenDeVenta_Producto>? OrdenDeVenta_Productos { get; set; } // n:n con OrdenDeVenta

    }
}
