using Microsoft.AspNetCore.Mvc;

namespace Kai.Controllers;

[ApiController]
[Route("api/dynamic-query-params")]
public class DynamicQueryParamsController : ControllerBase
{
    [HttpGet]
    public IResult Get([FromQuery] IDictionary<string, string[]> queryParams)
    {
        return Results.Ok(queryParams);
    }
}