using FluentAssertions;
using Xunit;

namespace DotnetTemplate.Tests;

public class UnitTest
{
    private const string MethodOneOutput = "Output from method one.";
    private const string MethodTwoOutput = "Output from method two.";

    [Fact]
    public void TestMethodOne()
    {
        _ = MySampleService.MethodOne().Should().Be(MethodOneOutput);
    }

    [Fact]
    public void TestMethodTwo()
    {
        _ = MySampleService.MethodTwo().Should().Be(MethodTwoOutput);
    }
}