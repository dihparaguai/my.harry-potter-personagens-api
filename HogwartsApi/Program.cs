using HogwartsApi.Modelos;
using System.Text.Json;
List<Personagem> personagens = new(); 
using (HttpClient client = new HttpClient())
{
    string res = await client.GetStringAsync("https://hp-api.onrender.com/api/characters/house/gryffindor");
    personagens = JsonSerializer.Deserialize<List<Personagem>>(res)!;
}

foreach (var item in personagens)
{
    item.ExibirDetalhes();
}