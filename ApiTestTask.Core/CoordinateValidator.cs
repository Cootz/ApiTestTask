namespace ApiTestTask.Core
{
    public static class CoordinateValidator
    {
        public const int MIN_LATITUDE = -90;
        public const int MAX_LATITUDE = 90;
        public const int MIN_LONGITUDE = -180;
        public const int MAX_LONGITUDE = 180;

        /// <summary>
        /// Validate coordinate's latitude and longitude
        /// </summary>
        /// <returns><see langword="true"/> if coordinate is valid, else <see langword="false"/></returns>
        public static bool Validate(this Coordinate coordinate)
        {
            bool isValid = true;

            isValid &= coordinate.Longitude is >= MIN_LONGITUDE and <= MAX_LONGITUDE;
            isValid &= coordinate.Latitude is >= MIN_LATITUDE and <= MAX_LATITUDE;

            return isValid;
        }
    }
}