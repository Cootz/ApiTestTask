namespace ApiTestTask.Core
{
    /// <summary>
    /// Generate random list of earth <see cref="Coordinate"/>s
    /// </summary>
    public class CoordinatesGenerator
    {
        public const int MIN_LATITUDE = -90;
        public const int MAX_LATITUDE = 90;

        public const int MIN_LONGITUDE = -180;
        public const int MAX_LONGITUDE = 180;

        public IEnumerable<Coordinate> Generate(int count)
        {
            if (count <= 0)
                return Enumerable.Empty<Coordinate>();

            Random rnd = new();

            return Enumerable.Range(1, count)
                .Select(c =>
                    new Coordinate(rnd.Next(MIN_LATITUDE, MAX_LATITUDE), rnd.Next(MIN_LONGITUDE, MAX_LONGITUDE)));
        }
    }
}
