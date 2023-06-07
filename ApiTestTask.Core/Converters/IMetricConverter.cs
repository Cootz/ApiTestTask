namespace ApiTestTask.Core.Converters
{
    public interface IMetricConverter
    {
        double Convert(double value);
        double ConvertBack(double value);
    }
}
