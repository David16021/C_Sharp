using LibPedidos;

//clsClientes cliente;
//cliente = new clsClientes();
//cliente.idCliente = 1;
//cliente.NombreCompleto = "Harold Perez";
//cliente.Rfc = "HEHM10165";
//Console.WriteLine(cliente.ToString());

clsProductos Producto = new clsProductos();
Producto.idProducto = 1;
Producto.Descripcion = "Ref Manzana 600 ML";
Producto.CodigoBarras = "0001";
clsProductos Producto2 = new clsProductos();
Producto2 = Producto;
Producto2.CodigoBarras = "0";

recProductos rProducto = new recProductos(1, "Ref Manzana 600 ML", "0001");
recProductos rProducto2 = rProducto with { CodigoBarras = "0"};
Console.WriteLine("Producto: " + Producto);
Console.WriteLine("Producto2: " + Producto2);
Console.WriteLine("rProducto: " + rProducto);
Console.WriteLine("rProducto2: " + rProducto2);

if (Producto == Producto2)
    Console.WriteLine("Los objetos son iguales");
else
    Console.WriteLine("Los objetos son diferentes");
if (rProducto == rProducto2)
    Console.WriteLine("Los registros son iguales");
else
    Console.WriteLine("Los registros son diferentes ");