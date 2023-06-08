using ApiTestTask.Controllers;
using ApiTestTask.Core;
using Microsoft.AspNetCore.Mvc;

namespace ApiTestTask.Tests.API
{
    [TestFixture]
    public class CoordinatesControllerTest
    {
        readonly CoordinatesController controller = new();

        [Test]
        public void GetReturnsCoordinates()
        {
            const int count = 3;

            IEnumerable<Coordinate>? coordinates =
                (IEnumerable<Coordinate>?)(controller.GetCoordinates(count) as ObjectResult)?.Value;

            Assert.That(coordinates?.Count(), Is.EqualTo(count));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetReturnsBadRequest(int count)
        {
            IActionResult result = controller.GetCoordinates(count);

            Assert.That(result, Is.TypeOf<BadRequestResult>());
        }

        //We don't need to test every possibility here as it's already tested in DistanceCalculatorTest
        [Test]
        public void PostReturnsDistance()
        {
            Coordinate[] coordinates =
            {
                new(10, 20),
                new(20, 30)
            };

            Distance? distance = (Distance?)(controller.CalculateDistance(coordinates) as ObjectResult)?.Value;

            Assert.That(distance?.Meters, Is.GreaterThan(0));
        }

        [Test]
        public void PostReturnsBadRequest()
        {
            Coordinate[] coordinates =
            {
                new(110, 220),
                new(10, 20)
            };

            IActionResult result = controller.CalculateDistance(coordinates);

            Assert.That(result, Is.TypeOf<BadRequestObjectResult>());
        }
    }
}
