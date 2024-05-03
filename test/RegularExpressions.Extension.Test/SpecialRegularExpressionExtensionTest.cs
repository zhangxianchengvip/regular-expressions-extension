using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions.Extension.Test
{
    public class SpecialRegularExpressionExtensionTest
    {
        [Theory]
        [InlineData("email@example.com")]
        public void Shoud_Match_Email(string input)
        {
            var result = input.IsEmail();
            Assert.True(result);
        }

        [Theory]
        [InlineData("emailexample.com")]
        public void Shoud_Match_Not_Email(string input)
        {
            var result = input.IsEmail();
            Assert.False(result);
        }

        [Theory]
        [InlineData("15971241527")]
        public void Shoud_Match_Phone_Number(string input)
        {
            var result = input.IsPhone();
            Assert.True(result);
        }

        [Theory]
        [InlineData("123456789111")]
        public void Shoud_Match_Not_Phone_Number(string input)
        {
            var result = input.IsPhone();
            Assert.False(result);
        }

        [Theory]
        [InlineData("https://www.example.com")]
        public void Shoud_Match_Url(string input)
        {
            var result = input.IsUrl();
            Assert.True(result);
        }

        [Theory]
        [InlineData("://www.example.com")]
        public void Shoud_Match_Not_Url(string input)
        {
            var result = input.IsUrl();
            Assert.False(result);
        }

        [Theory]
        [InlineData("2024-01-01")]
        [InlineData("2024-01-01 12:00")]
        [InlineData("2024-01-01 12:00:00")]
        public void Shoud_Match_DateTime(string input)
        {
            var result = input.IsDateTime();
            Assert.True(result);
        }

        [Theory]
        [InlineData("2024")]
        [InlineData("2024-01")]
        public void Shoud_Match_Not_DateTime(string input)
        {
            var result = input.IsDateTime();
            Assert.False(result);
        }

        [Theory]
        [InlineData("420621199812154515")]
        [InlineData("42062119981215451x")]
        public void Shoud_Match_IdentityCard(string input)
        {
            var result = input.IsIdentityCard();
            Assert.True(result);
        }

        [Theory]
        [InlineData("1234567891234567")]
        public void Shoud_Match_Not_IdentityCard(string input)
        {
            var result = input.IsIdentityCard();
            Assert.False(result);
        }

        [Theory]
        [InlineData("365839159")]
        public void Shoud_Match_QQ(string input)
        {
            var result = input.IsQq();
            Assert.True(result);
        }

        [Theory]
        [InlineData("365111111111839159")]
        public void Shoud_Match_Not_QQ(string input)
        {
            var result = input.IsQq();
            Assert.False(result);
        }

        [Theory]
        [InlineData("127.0.0.1")]
        public void Shoud_Match_IP(string input)
        {
            var result = input.IsIp();
            Assert.True(result);
        }

        [Theory]
        [InlineData("127.0")]
        public void Shoud_Match_Not_IP(string input)
        {
            var result = input.IsIp();
            Assert.False(result);
        }
    }
}
