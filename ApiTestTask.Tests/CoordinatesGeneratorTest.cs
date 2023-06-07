using ApiTestTask.Core;

namespace ApiTestTask.Tests
{
    public class CoordinatesGeneratorTest
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(100)]
        public void GenerateTest(int n)
        {
            CoordinatesGenerator generator = new();

            IEnumerable<Coordinate> coordinates = generator.Generate(n);

            Assert.Multiple(() =>
            {
                foreach (Coordinate coordinate in coordinates)
                {
                    Assert.That(coordinate.Longitude,
                        Is.InRange(CoordinatesGenerator.MIN_LONGITUDE, CoordinatesGenerator.MAX_LONGITUDE));
                    Assert.That(coordinate.Latitude,
                        Is.InRange(CoordinatesGenerator.MIN_LATITUDE, CoordinatesGenerator.MAX_LATITUDE));
                }
            });
        }
    }
}
