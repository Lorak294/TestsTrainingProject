using TestsTrainingProject;

namespace TestTrainingTests
{
    public class TenMultiplierTests
    {
        [Fact]
        public void ZeroMultiplicaionReturnsZero()
        {
            int result = TenMultiplier.MultiplyBy10(0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,10)]
        [InlineData(2,20)]
        [InlineData(3,30)]
        [InlineData(4,40)]
        public void PositiveNumbersMultiplicationTest(int testNumber, int expectedResult)
        {
            int result = TenMultiplier.MultiplyBy10(testNumber);
            Assert.Equal(result,expectedResult);
        }
    }
}