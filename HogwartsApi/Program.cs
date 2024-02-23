using HogwartsApi.Modelos;
using System.Text.Json;
using (HttpClient client = new HttpClient()) // desserializando a api na lista de personagens
{
    try
    {
        string res = await client.GetStringAsync("https://hp-api.onrender.com/api/characters/");

        var personagens = JsonSerializer.Deserialize<List<Personagem>>(res)!; // coloca a lista de personagens numa lista de objetos

        
        foreach (var p in personagens)
        {
            p.ExibirDetalhes();
        }


        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine(@"1 - Listar Todas as Casas
2 - Filtrar por Casa
3 - Filtrar por Sobrenome
4 - Filtrar por Sexo
5 - Filtrar por Pratono
5 - Criar seu Personagem
6 - Sair
");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Conexão com API comprometida => {e}");
    }
}

