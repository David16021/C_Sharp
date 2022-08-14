public record recProductos
{
    public int idProducto { get; set; }
    public string Descripcion { get; set; }
    public string CodigoBarras { get; set; }
    public recProductos(int id, string descripcion, string codigobarras)
    {
        this.idProducto = id;
        this.Descripcion = descripcion;
        this.CodigoBarras = codigobarras;
    }
}