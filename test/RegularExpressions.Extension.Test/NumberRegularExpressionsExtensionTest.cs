using System.Text.RegularExpressions;
using RegularExpressions.Extension;
namespace RegularExpressions.Extension.Test
{
    public class NumberRegularExpressionsExtensionTest
    {

        [Theory]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData("123")]
        [InlineData("999999")]
        public void Should_Match_Number(string input)
        {
            bool result = input.IsNumber();
            Assert.True(result);
        }

        [Theory]
        [InlineData("test")]
        public void Should_Match_Not_Number(string input)
        {
            bool result = input.IsNumber();
            Assert.False(result);
        }
    }
}