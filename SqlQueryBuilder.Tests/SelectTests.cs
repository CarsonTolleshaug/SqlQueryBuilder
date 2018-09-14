using FluentAssertions;
using System;
using Xunit;

namespace SqlQueryBuilder.Tests
{
    public class SelectTests
    {
        [Fact]
        public void Test1()
        {
            new Select("*").From("MyTable").Where("Id = 14").ToString()
                .Should().Be("SELECT * FROM MyTable WHERE Id = 14");
        }
    }
}
