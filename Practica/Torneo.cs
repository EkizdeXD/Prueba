public class Torneo
{
    public string Nombre { get; set; }
    public string Fecha { get; set; }
    public string LugarDeTransmisión { get; set; }

    public List<Equipo> EquiposRegistrados { get; set; } = new List<Equipo>();

    public virtual string ObtenerDetalles()
    {
        return $"Nombre: {Nombre} - Fecha: {Fecha} - Lugar de Transmisión: {LugarDeTransmisión}";
    }

    public virtual void InscribirEquipo(Equipo equipo)
    {
        EquiposRegistrados.Add(equipo);
    }

    public string ListaEquipos()
    {
        if (EquiposRegistrados.Count == 0)
        {
            return "No hay equipos registrados...";
        }
        
        string equiposInfo = "Equipos registrados:\n";

        // Utilizando un bucle for
        for (int i = 0; i < EquiposRegistrados.Count; i++)
        {
            if (i == EquiposRegistrados.Count - 1) // Verifica si es el último o único elemento
            {
                equiposInfo += EquiposRegistrados[i].Nombre + ".";
                return equiposInfo;
            }
            else
            {
                equiposInfo += EquiposRegistrados[i].Nombre + ", ";
            }
        }

        // Utilizando un bucle foreach
        foreach (Equipo equipo in EquiposRegistrados)
        {
            if (equipo == EquiposRegistrados.Last())
            {
                equiposInfo += equipo.Nombre + ".";
                return equiposInfo;
            }
            else
            {
                equiposInfo += equipo.Nombre + ", ";
            }
        }

        // Consulta LINQ para obtener los nombres de los equipos registrados
        return string.Join(", ", EquiposRegistrados.Select(e => e.Nombre));
    }
}