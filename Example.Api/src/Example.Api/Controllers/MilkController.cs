using Example.Api.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Example.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MilkController : ControllerBase
{
    private readonly HttpClient _client;

    public MilkController(HttpClient client)
    {
        _client = client;
    }

    [HttpGet]
    public Task<MilkResponse> GetMilk() => _client.GetFromJsonAsync<MilkResponse>("http://localhost:5031/milk")!;
}