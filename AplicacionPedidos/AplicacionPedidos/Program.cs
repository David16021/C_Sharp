﻿global using LibPedidos;
using AplicacionPedidos;
int opcion = 0;
do
{
    Console.WriteLine("Menu de opciones");
    Console.WriteLine();
    Console.WriteLine("1. Ejemplo de cliente");
    Console.WriteLine("2. Ejemplo de record de producto");
    Console.WriteLine("3. Ejemplo de paso de párametros a un Método");
    Console.WriteLine("20. Salir");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            FuncionesPrincipales.EjemploCliente();
            break;
        case 2:
            FuncionesPrincipales.EjemploRecordProducto();
            break;
        default:
            break;
    }
} while (opcion != 20);