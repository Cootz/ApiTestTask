using ApiTestTask.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace ApiTestTask.Controllers
{
    /// <summary>
    /// Handle earth's coordinates
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatesController : ControllerBase
    {
        /// <summary>
        /// Generate list of earth <see cref="Coordinate"/>s
        /// </summary>
        /// <param name="count">Number of <see cref="Coordinate"/>s. MUST BE >= 1</param>
        /// <returns>List of earth <see cref="Coordinate"/>s</returns>
        [HttpGet]
        public IActionResult GetCoordinates(int count)
        {
            CoordinatesGenerator coordinatesGenerator = new();

            IEnumerable<Coordinate> coordinates = coordinatesGenerator.Generate(count);

            if (!coordinates.Any())
                return BadRequest();

            return Ok(coordinates);
        }

        [HttpPost]
        public IActionResult CalculateDistance([FromBody] IEnumerable<Coordinate> coordinates) =>
            throw new NotImplementedException();
    }
}
