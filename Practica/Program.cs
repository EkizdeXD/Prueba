using System.ComponentModel;

List<Torneo> ListaDeTorneos = new List<Torneo>();
Console.WriteLine("Elija una de las opciones porfavor :D");
Console.WriteLine("0 - Salir | 1 - Crear Torneo | 2 - Listar Torneos | 3 - Buscar Torneo | 4 - Inscribir Equipo");
Console.WriteLine();
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
while (n != 0)
{
    switch (n)
    {
        case 1:
            CrearTorneo();
            break;
        case 2:
            ListarTorneos();
            break;
        case 3:
            BuscarTorneo();
            break;
        case 4:
            InscribirEquipos();
            break;
        default:
            Console.WriteLine("Ese no es un numero valido ._.");
            break;
    }
    Console.WriteLine();
    Console.WriteLine("Elija una de las opciones porfavor :D");
    Console.WriteLine("0 - Salir | 1 - Crear Torneo | 2 - Listar Torneos | 3 - Buscar Torneo | 4 - Inscribir Equipo");
    Console.WriteLine();
    n = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
Console.WriteLine("Nos vemos ^_^");
Console.ReadKey();

void CrearTorneo()
    {
        n = 0;
        Console.WriteLine("Elija el tipo de torneo :)");
        Console.WriteLine("1 - Torneo Competitivo | 2 - Torneo Casual");
        Console.WriteLine();
        n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (n == 1)
        {
            TorneoCompetitivo TorneoCompetitivo = new TorneoCompetitivo();
            Console.WriteLine("Ingrese nombre del torneo:");
            TorneoCompetitivo.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese fecha del torneo:");
            TorneoCompetitivo.Fecha = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese lugar de transmisión:");
            TorneoCompetitivo.LugarDeTransmisión = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese premio:");
            TorneoCompetitivo.Premio = Console.ReadLine();
            ListaDeTorneos.Add(TorneoCompetitivo);
        }
        else if (n == 2)
        {
            TorneoCasual TorneoCasual = new TorneoCasual();
            Console.WriteLine("Ingrese nombre del torneo:");
            TorneoCasual.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese fecha del torneo:");
            TorneoCasual.Fecha = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese lugar de transmisión:");
            TorneoCasual.LugarDeTransmisión = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese limite de equipos:");
            TorneoCasual.LimiteEquipos = int.Parse(Console.ReadLine());
            ListaDeTorneos.Add(TorneoCasual);
        }
        else
        {
            Console.WriteLine("Ese no es un numero valido ._.");
        }
    }

    void ListarTorneos()
    {
        if (ListaDeTorneos.Count <= 0)
        {

        }
        else
        {
            for (int i = 0; i < ListaDeTorneos.Count; i++)
            {
                Console.WriteLine(ListaDeTorneos[i].ObtenerDetalles());
                Console.WriteLine();
            }
        }
    }

    void BuscarTorneo()
    {
        Console.WriteLine("Ingrese nombre del torneo:");
        Console.WriteLine();
        string L = Console.ReadLine();
        Console.WriteLine();
        bool Find = false;
        foreach (var Torneo in ListaDeTorneos)
        {
            if (Torneo.Nombre.ToLower() == L.ToLower())
            {
                Console.WriteLine("Coincidencias:");
                Console.WriteLine(Torneo.ObtenerDetalles());
                Find = true;
            }
        }
        if (!Find)
        {
            Console.WriteLine();
            Console.WriteLine("Ese torneo no existe ._.");
        }
    }

    void InscribirEquipos()
    {
        Console.WriteLine("Ingrese nombre del torneo:");
        string L = Console.ReadLine();
        Console.WriteLine();
        bool Find = false;
        for (int i = 0; i < ListaDeTorneos.Count; i++)
        {
            if (ListaDeTorneos[i].Nombre.ToLower() == L.ToLower())
            {
                Find = true;
                TorneoCasual TorneoCasual = ListaDeTorneos[i] as TorneoCasual;
                if (TorneoCasual != null)
                {
                    Console.Write("Ingrese el nombre del equipo: ");
                    Console.WriteLine();
                    string L2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(TorneoCasual.InscribirEquipoConLimite(L2));
                }
                else
                {
                    Console.WriteLine("Este torneo es competitivo ._.");
                }
                break;
            }
        }
        if (!Find)
        {
            Console.WriteLine("Ese torneo no existe ._.");
        }
    }