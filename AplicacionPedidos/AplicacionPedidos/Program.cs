using LibPedidos;

clsClientes cliente;
cliente = new clsClientes();
cliente.idCliente = 1;
cliente.NombreCompleto = "Harold Perez";
cliente.Rfc = "HEHM10165";
Console.WriteLine(cliente.ToString());