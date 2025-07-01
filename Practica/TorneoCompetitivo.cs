using System.Dynamic;

public class TorneoCompetitivo : Torneo
{
    public string Premio { get; set; }

    public string ObetenerDetalles()
    {
        return $"Nombre: {Nombre} - Fecha: {Fecha} - Lugar de Transmisión: {LugarDeTransmisión} - Premio: {Premio}";
    }
}