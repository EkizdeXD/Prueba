public class TorneoCasual : Torneo
{
    public int LimiteEquipos { get; set; }

    public string ObetenerDetalles()
    {
        return $"Nombre: {Nombre} - Fecha: {Fecha} - Lugar de Transmisión: {LugarDeTransmisión} - Limite de Equipos: {LimiteEquipos}";
    }

    public string InscribirEquipoConLimite(Equipo Equipo)
    {
        if (EquiposRegistrados.Count < LimiteEquipos)
        {
            EquiposRegistrados.Add(Equipo);
            return "Equipo inscrito con éxito :D";
        }
        else
        {
            return "No hay cupos disponibles...";
        }
    }
}