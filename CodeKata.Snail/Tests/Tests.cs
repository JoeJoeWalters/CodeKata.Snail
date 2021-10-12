using Core;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class Tests
    {
        private readonly int[] test1 = { 1, 2, 3, 4 };
        private readonly int[][] testResult1 =
        {
            new []{ 1, 2 },
            new []{ 4, 3 },
        };

        [Fact]
        public void If_Given_Array_Produces_Snail_Array()
        {
            // ARRANGE
            var sort = new SnailSort();

            // ACT
            int[][] result = sort.Go();

            // ASSERT
            result.Should().Equal(testResult1);
        }
    }
}
