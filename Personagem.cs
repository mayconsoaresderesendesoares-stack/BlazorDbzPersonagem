using System.Text.Json.Serialization;

namespace BlazorDbzPersonagem.Models
{
    public class Personagem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("originPlanet")]
        public OriginPlanet? PlanetaOrigem { get; set; }

        [JsonPropertyName("transformations")]
        public List<Transformacao>? Transformacoes { get; set; }
    }

    public class OriginPlanet
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }
    }

    public class Transformacao
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }
    }
}