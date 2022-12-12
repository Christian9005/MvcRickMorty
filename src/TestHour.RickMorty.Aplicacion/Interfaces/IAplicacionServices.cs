
using TestHour.RickMorty.Aplicacion.Dtos;
using TestHour.RickMorty.Dominio;

namespace TestHour.RickMorty.Aplicacion.Interfaces;

public interface IAplicacionServices
{
    Task<ICollection<PersonajesDto>> GetAllAsync();
}
