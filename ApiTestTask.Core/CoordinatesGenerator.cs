namespace ApiTestTask.Core
{
    public class CoordinatesGenerator
    {
        public const int MIN_LATITUDE = -90;
        public const int MAX_LATITUDE = 90;

        public const int MIN_LONGITUDE = -180;
        public const int MAX_LONGITUDE = 180;

        /// <summary>
        /// Generate random list of earth <see cref="Coordinate"/>s
        /// </summary>
        /// <param name="n">Number of <see cref="Coordinate"/>s to generate</param>
        public IEnumerable<Coordinate> Generate(int n)
        {
            if (n <= 0)
                return Enumerable.Empty<Coordinate>();

            Random rnd = new();

            return Enumerable.Range(1, n)
                .Select(c =>
                    new Coordinate(rnd.Next(MIN_LATITUDE, MAX_LATITUDE), rnd.Next(MIN_LONGITUDE, MAX_LONGITUDE)));
        }
    }
}
