using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;


namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(new [] {4,3,5,8,5,0,0,-3}, new [] {3,5,8})]
        // TODO: add more scenarios to ensure finder is working properly
        [InlineData(new int[] { }, new int[] { })] 
        [InlineData(new [] {1}, new [] {1})]
        [InlineData(new [] {8,7,6,5,4,3,2,1,-1,-2}, new [] {8})]
        [InlineData(new [] {-2,-1,1,2,3,4,5,6,7,8}, new [] {-2,-1,1,2,3,4,5,6,7,8})]
        [InlineData(new [] {-8,-11,6,9,-4,-3,-2,-1,-11,-2}, new [] {-4,-3,-2,-1})]
        

        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = null;

            // TODO: create the finder instance and get the actual result
            var finder = new LongestRisingSequenceFinder();
            actual = await finder.Find(data);      
            actual.Should().Equal(expected);
        }
    }
}
