namespace ApiTestTask.Core.Converters
{
    /// <summary>
    /// Converts any metric system to any other metric system
    /// </summary>
    public interface IMetricConverter
    {
        /// <summary>
        /// Convert to target metric system
        /// </summary>
        double Convert(double value);

        /// <summary>
        /// Convert back to original metric system
        /// </summary>
        double ConvertBack(double value);
    }
}
