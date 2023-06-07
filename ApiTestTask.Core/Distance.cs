using ApiTestTask.Core.Converters;

namespace ApiTestTask.Core
{
    /// <summary>
    /// Store distance and convert it to different metric systems
    /// </summary>
    /// <remarks>
    /// Any metric system you set will be converted and stored as <see cref="Meters"/>
    /// </remarks>
    public class Distance
    {
        private readonly MetersToMilesConverter metersToMilesConverter = new();

        public double Meters { get; set; }

        public double Miles
        {
            get => metersToMilesConverter.Convert(Meters);
            set => Meters = metersToMilesConverter.ConvertBack(value);
        }

        public Distance()
        {
        }

        public Distance(double meters) => Meters = meters;
    }
}
