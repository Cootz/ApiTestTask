using ApiTestTask.Core;
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

        /// <summary>
        /// Calculates sum of distances between a given array of coordinates
        /// </summary>
        /// <returns>Sum of distances between coordinates</returns>
        [HttpPost]
        public IActionResult CalculateDistance([FromBody] IEnumerable<Coordinate> coordinates)
        {
            DistanceCalculator distanceCalculator = new();

            double distanceInMeters = 0;

            try
            {
                distanceInMeters = distanceCalculator.Calculate(coordinates);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return BadRequest(e);
            }

            return Ok(new Distance(distanceInMeters));
        }
    }
}