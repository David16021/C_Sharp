string nombre = "Harold Perez";
Console.WriteLine(nombre == "HarOld Perez");
Console.WriteLine(nombre.Equals("Harold Perez", StringComparison.OrdinalIgnoreCase));
if(nombre == "HarOld Perez")
    Console.WriteLine("El nombre: " + nombre + " es igual a Harold Perez");
else
    Console.WriteLine("El nombre: " + nombre + " no es igual a HarOld Perez");
if (nombre.Equals("HAROLD PEREZ", StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("El nombre: " + nombre + " es igual a HAROLD PEREZ");
else
    Console.WriteLine("El nombre: " + nombre + " no es igual a HAROLD PEREZ");
DateTime fecha = DateTime.Now;
Console.WriteLine(fecha.ToShortDateString());
Console.WriteLine(fecha.ToLongDateString());
Console.WriteLine(fecha.ToString("yyyy-MM-dd HH:mm:ss"));