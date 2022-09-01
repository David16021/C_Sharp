using Eventos;

int opcion = 0;
do
{
    Console.WriteLine("1. Eventos con delegados");
    Console.WriteLine("10. Salir");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            clsRepositorioDelegado repo = new clsRepositorioDelegado();
            repo.ReportaAvance += MuestraAvance;
            repo.ObtenTodos();
            break;
        default:
            break;
    }
} while (opcion != 10);

void MuestraAvance(int valor)
{
    Console.Write(valor.ToString()+ " ");
}