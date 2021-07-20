using System;
using FluentAssertions;
using Geolocation;
using PocketGo.App.Models;
using Xunit;

namespace PocketGo.App.Tests.Models
{
    public class WorldObjectTests
    {
        [Fact]
        public void Given_New_WorldObject_Is_Constructed_Then_Id_Is_Set()
        {
            // Arrange   
            // Act
            var worldObj = new WorldObject();
        
            // Assert
            worldObj.Id.Should().NotBe(Guid.Empty);            
        }

        [Fact]
        public void Given_New_WorldObject_Is_Constructed_Without_InitialPosition_Then_Default_Position_Is_Assigned()
        {
            // Arrange
            Coordinate defaultPosition = default;

            // Act
            var worldObj = new WorldObject();
        
            // Assert
            worldObj.Position.Should().Be(defaultPosition);
            
        }

        [Fact]
        public void Given_New_WorldObject_Is_Constructed_With_InitialPosition_Then_Position_Is_Set_To_InitialPostion()
        {
            // Arrange
            var initialPosition = CreateCoordinate(10.2, 503.4);
        
            // Act
            var worldObj = new WorldObject(initialPosition);            
        
            // Assert
            worldObj.Position.Should().Be(initialPosition);
        }

        private Coordinate CreateCoordinate(double lat, double lon)
        {
            var coordinate = new Coordinate();

            coordinate.Latitude = lat;
            coordinate.Longitude = long;

            return coordinate;
        }
    }
}