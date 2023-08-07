using LeetCodeTraining.TwoSum1;

namespace LeetCodeTraining.Tests
{
    public class TwoSumSolutionTests
    {
        [Fact]
        public void TwoSum_ArrayWith2Nums()
        {
            //Arrange
            var nums = new int[] { 3, 3 };
            int target = 6;
            var expectedResult = new int[] { 0, 1 };

            //Act
            var result = TwoSumSolution.TwoSum(nums, target);

            //Assert
            Assert.Equal(expectedResult.Length, result.Length);
            Array.Sort(result);
            for(var i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}