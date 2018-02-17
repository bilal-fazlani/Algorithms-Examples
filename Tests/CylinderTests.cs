using Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class CylinderTests
    {
        [Theory]
        [InlineData(2D, 4D, 50.265482457436692)]
        public void ShouldReturnVolumeOfCylinder(double radius, double height, double expectedVolume)
        {
            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.GetVolume().Should().Be(expectedVolume);
        }
    }
}