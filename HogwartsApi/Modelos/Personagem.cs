using System.Text.Json.Serialization;

namespace HogwartsApi.Modelos;

internal class Personagem
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("gender")]
    public string? sexo { private get; set; }
    public string? Sexo
    {
        get
        { 
            return (sexo == "male") ? "Masculino": "Feminino";
        } 
    }
    [JsonPropertyName("house")]
    public string? Casa { get; set; }

    internal void ExibirDetalhes()
    {
        Console.WriteLine($@"
Nome do Personagem: {Nome}
Sexo: {Sexo}
Casa: {Casa}
");
    }
}
