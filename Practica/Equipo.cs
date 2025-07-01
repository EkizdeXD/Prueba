public class Equipo
{
    public string Nombre { get; set; }

    List<string> Jugadores = new List<string>();

    public string ObtenerInfoEquipo()
    {
        return $"Nombre del Equipo: {Nombre} - Cantidad de Jugadores: {Jugadores}";
    }
}