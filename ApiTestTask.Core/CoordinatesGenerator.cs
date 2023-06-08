namespace ApiTestTask.Core
{
    public class CoordinatesGenerator
    {
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
                    new Coordinate(rnd.Next(CoordinateValidator.MIN_LATITUDE, CoordinateValidator.MAX_LATITUDE),
                        rnd.Next(CoordinateValidator.MIN_LONGITUDE, CoordinateValidator.MAX_LONGITUDE)));
        }
    }
}
