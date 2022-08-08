using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        //1 for a valid string
        //1 for a empty string
        //1 for a null string
        //1 that has the longitude but doesn't have the latitude


        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)] //valid string
        [InlineData("34.047374,-84.223918, Taco Bell Alpharetta...", -84.223918)] //valid string
        [InlineData(",-85.291147,Taco Bell Chattanooga...", null)] //no latitude
        [InlineData("34.761813,,Taco Bell Huntsville...", null)] // no longitude
        [InlineData("", null)] //empty string
        [InlineData(null, null)] //null string

        public void ShouldParseLongitude(string line, double? expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange

            var tacoParser1 = new TacoParser();

            //Act

            var actual = tacoParser1.Parse(line);

            //Assert

            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)] //valid string
        [InlineData("34.047374,-84.223918, Taco Bell Alpharetta...", 34.047374)] //valid string
        [InlineData(",-85.291147,Taco Bell Chattanooga...", null)] //no latitude 
        [InlineData("34.761813,,Taco Bell Huntsville...", null)] //no longitude
        [InlineData("", null)] // empty string
        [InlineData(null, null)] //null string



        public void ShouldParseLatitude(string line, double? expected)
        {

            //Arrange
            var tacoParser2 = new TacoParser();

            //Act
            var actual = tacoParser2.Parse(line);

            //Assert

            Assert.Equal(expected, actual.Location.Latitude);

        }
    }
}
