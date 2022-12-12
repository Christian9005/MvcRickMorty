using Microsoft.AspNetCore.Mvc;
using TestHour.RickMorty.Aplicacion.Dtos;
using TestHour.RickMorty.Aplicacion.Interfaces;
using TestHour.RickMorty.Dominio;

namespace TestHour.RickMorty.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ApiController: ControllerBase
{
    private readonly IAplicacionServices personajesAppService;
    public ApiController(IAplicacionServices personajesAppService)
    {
        this.personajesAppService = personajesAppService;
    }

    [HttpGet]
    public async Task<ICollection<PersonajesDto>> GetAllAsync()
    {
        return await personajesAppService.GetAllAsync();
    }
}
