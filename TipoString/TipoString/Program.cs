﻿string cadena = "Hola Mundo";
string cadena2 = cadena;
cadena = "Hola programadores \n\"Mensaje de bienvenida\"";
string ruta = "C:\\Usuarios\\David\\Documentos";
string ruta2 = @"C:\Usuarios\David\Documentos";
int programadores = 14;
decimal sueldo = 10500.5m;
string comunidad = $"Existen {programadores} programadores en la comunidad que ganan {sueldo:C}";
int tamanio = ruta.Length;
string nombre = "   David Perez    ";
Console.WriteLine(cadena);
Console.WriteLine(cadena2);
Console.WriteLine(ruta);
Console.WriteLine(ruta2);
Console.WriteLine(comunidad);
Console.WriteLine("El taaño de la cadena de la ruta es {0}", tamanio);
Console.WriteLine("Metodos de string");
Console.WriteLine(nombre);
Console.Write(nombre.Trim());
Console.WriteLine("Fin de la impresion");
Console.WriteLine(nombre.Substring(0, 5));
Console.WriteLine(nombre.Substring(3,5));
Console.WriteLine(nombre.StartsWith("   D"));
Console.WriteLine(nombre.Contains("David"));
Console.WriteLine(nombre.Replace('a', 'e'));
Console.WriteLine(nombre.Trim().ToLower());
Console.WriteLine(nombre.Trim().ToUpper());
Console.ReadKey();