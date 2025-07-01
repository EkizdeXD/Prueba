public class Torneo
{
    public string Nombre { get; set; }
    public string Fecha { get; set; }
    public string LugarDeTransmisión { get; set; }

    public List<string> EquiposRegistrados = new List<string>();

    public virtual string ObtenerDetalles()
    {
        return $"Nombre: {Nombre} - Fecha: {Fecha} - Lugar de Transmisión: {LugarDeTransmisión}";
    }

    public virtual void InscribirEquipo(string Equipo)
    {
        EquiposRegistrados.Add(Equipo);
    }

    public string ListaEquipos()
    {
        if (EquiposRegistrados.Count == 0)
        {
            return "No hay cupos disponibles...";
        }
        return string.Join(", ", EquiposRegistrados);
    }
}