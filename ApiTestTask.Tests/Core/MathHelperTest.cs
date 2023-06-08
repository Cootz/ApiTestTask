using ApiTestTask.Tests.TestData;
using static ApiTestTask.Core.Helpers.MathHelper;

namespace ApiTestTask.Tests.Core
{
    [TestFixture]
    public class MathHelperTest
    {
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(180, ExpectedResult = Math.PI)]
        [TestCase(90, ExpectedResult = Math.PI / 2)]
        [TestCase(45, ExpectedResult = Math.PI / 4)]
        public double ToRadiansTest(double value) => value.ToRadians();

        [TestCaseSource(typeof(MathHelperTestDataSource), nameof(MathHelperTestDataSource.GetSinCosTestCases))]
        [DefaultFloatingPointTolerance(0.000000001)]
        public ValueTuple<double, double> GetSinCosTest(double value) => GetSinCosFor(value);
    }
}
