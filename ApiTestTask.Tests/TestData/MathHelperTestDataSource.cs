using System.Collections;

namespace ApiTestTask.Tests.TestData
{
    internal class MathHelperTestDataSource
    {
        public static IEnumerable GetSinCosTestCases
        {
            get
            {
                yield return new TestCaseData(0).Returns((0d, 1d));
                yield return new TestCaseData(Math.PI / 2).Returns((1d, 0d));

                double rootOfTwoDividedByTwo = Math.Sqrt(2) / 2;

                yield return new TestCaseData(-Math.PI + Math.PI / 4)
                    .Returns((-rootOfTwoDividedByTwo, -rootOfTwoDividedByTwo));
            }
        }
    }
}
