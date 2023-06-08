using ApiTestTask.Core;
using ApiTestTask.Tests.Core.TestData;

namespace ApiTestTask.Tests.Core
{
    [TestFixture]
    public class DistanceCalculatorTest
    {
        private readonly DistanceCalculator distanceCalculator = new();

        [DefaultFloatingPointTolerance(0.01)]
        [TestCaseSource(typeof(DistanceCalculatorTestDataSource),
            nameof(DistanceCalculatorTestDataSource.CalculateDistanceTestCases))]
        public double CalculateDistanceTest(IEnumerable<Coordinate> coordinates) =>
            distanceCalculator.Calculate(coordinates);

        [Test]
        public void CalculateDistanceThrowsArgumentOutOfRangeExceptionTest()
        {
            Coordinate[] coordinates =
            {
                new(100, 200),
                new(10, 20),
            };

            Assert.Throws<ArgumentOutOfRangeException>(() => distanceCalculator.Calculate(coordinates));
        }
    }
}
