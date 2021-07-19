using Geolocation;

namespace PocketGo.App.Models
{
    /// <summary>
    ///     Interface for an object that can be positioned
    /// </summary>
    public interface IPositionable
    {
        /// <summary>
        ///  This objects position
        /// </summary>
        /// <value></value>
        public Coordinate Position { get; set; }
    }
}