using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace Kai.Controllers;

[ApiController]
[Route("api/dynamic-query-params")]
public class DynamicQueryParamsController : ControllerBase
{
    [HttpGet]
    public IResult Get([FromQuery] IDictionary<string, string[]> queryParams)
    {
        var uri = "http://localhost:5008/api/dynamic-query-params";
        
        foreach (var queryParam in queryParams)
        {
            foreach (var value in queryParam.Value)
            {
                uri = QueryHelpers.AddQueryString(uri, queryParam.Key, value);
            }
        }
        
        return Results.Ok(uri);
    }
}