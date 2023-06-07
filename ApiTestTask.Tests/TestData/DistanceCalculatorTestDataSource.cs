using System.Collections;
using ApiTestTask.Core;

namespace ApiTestTask.Tests.TestData
{
    internal class DistanceCalculatorTestDataSource
    {
        public static IEnumerable CalculateDistanceTestCases
        {
            get
            {
                yield return new TestCaseData(null).Returns(0);
                yield return new TestCaseData(Enumerable.Empty<Coordinate>()).Returns(0);
                yield return new TestCaseData(new object[]
                {
                    new Coordinate[]
                    {
                        new(77, -139)
                    }
                }).Returns(0);
                yield return new TestCaseData(new object[]
                {
                    new Coordinate[]
                    {
                        new(77, -139),
                        new(-77, -139)
                    }
                }).Returns(17124018.70d);
                yield return new TestCaseData(new object[]
                {
                    new Coordinate[]
                    {
                        new(77, -139),
                        new(-77, -139)
                    }
                }).Returns(17124018.70d);
                yield return new TestCaseData(new object[]
                {
                    new Coordinate[]
                    {
                        new(77.1539, -139.398),
                        new(-77.1804, -139.55)
                    }
                }).Returns(17161193.72d);
                yield return new TestCaseData(new object[]
                {
                    new Coordinate[]
                    {
                        new(40, 120),
                        new(77, 129),
                        new(77, -120)
                    }
                }).Returns(6512579d);
            }
        }
    }
}
