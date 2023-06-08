using ApiTestTask.Core.Converters;

namespace ApiTestTask.Tests.Core.Converters
{
    public class MetersToMilesConverterTest
    {
        private readonly IMetricConverter converter = new MetersToMilesConverter();

        [DefaultFloatingPointTolerance(0.0000000001)]
        [TestCase(1, ExpectedResult = 0.0006213712)]
        [TestCase(1609.344, ExpectedResult = 1)]
        public double ConvertToMilesTest(double meters) => converter.Convert(meters);

        [DefaultFloatingPointTolerance(0.0000000001)]
        [TestCase(1, ExpectedResult = 1609.344)]
        [TestCase(16, ExpectedResult = 25749.504)]
        public double ConvertBackToMetersTest(double miles) => converter.ConvertBack(miles);
    }
}