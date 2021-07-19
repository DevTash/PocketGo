using System;
using Geolocation;

namespace PocketGo.App.Models
{
    /// <summary>
    ///     Represents an object that can exist in a PocketGo world.
    /// </summary>
    public class WorldObject : IPositionable
    {
        /// <summary>
        ///     The current position of this PocketGo world object.
        /// </summary>
        private Coordinate _position;


        /// <summary>
        ///     Gets or sets the UNIQUE Id of this PocketGo world object.
        /// </summary>
        /// <value></value>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the position of this PocketGo world object.
        /// </summary>
        /// <value></value>
        public Coordinate Position { 
            get => _position; 
            set => _position = value; 
        }

        public WorldObject(Coordinate initialPosition = default)
        {
            _position = initialPosition;
        }
    }
}