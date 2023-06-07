using System.Runtime.CompilerServices;
using ApiTestTask.Core.Converters;

namespace ApiTestTask.Core
{
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
