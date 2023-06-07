namespace ApiTestTask.Core.Converters
{
    public class MetersToMilesConverter : IMetricConverter
    {
        private const double conversion_ratio = 1609.344;

        public double Convert(double value) => value / conversion_ratio;

        public double ConvertBack(double value) => value * conversion_ratio;
    }
}
