using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTestTask.Controllers
{
    /// <summary>
    /// Handle earth's coordinates
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> GetCoordinates(int count) => throw new NotImplementedException();

        [HttpPost]
        public string CalculateDistance(IEnumerable<string> coordinates) => throw new NotImplementedException();
    }
}
