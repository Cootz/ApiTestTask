﻿using ApiTestTask.Core.Helpers;
using static ApiTestTask.Core.Helpers.MathHelper;

namespace ApiTestTask.Core
{
    public class DistanceCalculator
    {
        /// <summary>
        /// Earth radius in meters
        /// </summary>
        public const double EARTH_RADIUS = 6_371_000;

        /// <summary>
        /// Calculates sum of distances between given <paramref name="coordinates"/>
        /// </summary>
        /// <returns>Sum of distances between given <paramref name="coordinates"/>. If number of <paramref name="coordinates"/> &lt; 2 returns 0 </returns>
        public double Calculate(IEnumerable<Coordinate>? coordinates)
        {
            double distanceSum = 0;

            if (coordinates is null)
                return distanceSum;

            Coordinate[] coordinatesArray = coordinates.ToArray();

            if (coordinatesArray.Length < 2)
                return distanceSum;

            if (coordinatesArray.Any(coordinate => !coordinate.Validate()))
            {
                throw new ArgumentOutOfRangeException(nameof(coordinates), "Given coordinate does not exist");
            }

            for (int i = 1; i < coordinatesArray.Length; i++)
            {
                distanceSum += calculateDistance(coordinatesArray[i - 1], coordinatesArray[i]);
            }

            return distanceSum;
        }

        private double calculateDistance(Coordinate c1, Coordinate c2)
        {
            (double sinC1, double cosC1) = GetSinCosFor(c1.Latitude.ToRadians());
            (double sinC2, double cosC2) = GetSinCosFor(c2.Latitude.ToRadians());

            double deltaLongitude = Math.Abs(c1.Longitude.ToRadians() - c2.Longitude.ToRadians());
            (double sinDelta, double cosDelta) = GetSinCosFor(deltaLongitude);

            //See reference formula here - https://wiki.gis-lab.info/images/8/89/Great-cirlcles-09.gif
            double top =
                Math.Sqrt(Math.Pow(cosC2 * sinDelta, 2) + Math.Pow(cosC1 * sinC2 - sinC1 * cosC2 * cosDelta, 2));

            double bottom = sinC1 * sinC2 + cosC1 * cosC2 * cosDelta;

            double angleDifference = Math.Atan2(top, bottom);
            double distance = angleDifference * EARTH_RADIUS;
            return distance;
        }
    }
}
