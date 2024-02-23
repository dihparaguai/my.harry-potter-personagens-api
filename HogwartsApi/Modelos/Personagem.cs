using System.Text.Json.Serialization;

namespace HogwartsApi.Modelos;

internal class Personagem
{

    [JsonPropertyName("name")]
    public string? Nome { get; set; } // recuperando o nome do personagem da api
    [JsonPropertyName("gender")]
    public string? sexo { private get; set; }
    public string? Sexo // recuperando o sexo do personagem da api, e convertendo para palavras em portugues
    {
        get
        { 
            return (sexo == "male") ? "Masculino": "Feminino";
        } 
    }
    [JsonPropertyName("house")]
    public string? Casa { get; set; } // recuperando a casa de hogwarts do personagem da api

    internal void ExibirDetalhes()
    {
        Console.WriteLine($@"Nome do Personagem: {Nome}
Sexo: {Sexo}
Casa: {((Casa == "") ? "Casa não informada" : Casa)}
");
    } // caso o personagem nao tenha casa, sera informado...
}
