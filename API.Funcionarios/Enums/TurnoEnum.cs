using System.Text.Json.Serialization;

namespace API.Funcionarios.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {
        Manha, 
        Tarde, 
        Noite
    }
}
