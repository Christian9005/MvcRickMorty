using System.Text.Json;
using TestHour.RickMorty.Aplicacion.Dtos;
using TestHour.RickMorty.Aplicacion.Interfaces;
using TestHour.RickMorty.Dominio;

namespace TestHour.RickMorty.Aplicacion;
public class AplicacionServices : IAplicacionServices
{
    const string URL = "https://rickandmortyapi.com/api/character";

    public async Task<ICollection<PersonajesDto>> GetAllAsync()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(URL);
        var content = await response.Content.ReadAsStringAsync();
        var rickAndMorty = JsonSerializer.Deserialize<Root>(content);
        var rickMorty = from m in rickAndMorty.results
                        select new PersonajesDto(){
                            id = m.id,
                            name = m.name
                        };
        
        return rickMorty.ToList();
    }
}
