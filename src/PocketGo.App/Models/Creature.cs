using System;

namespace PocketGo.App.Models
{
    /// <summary>
    ///     A PocketGo creature.
    /// </summary>
    public class Creature : WorldObject
    {
        /// <summary>
        ///     Gets or sets this creatures. 
        /// </summary>
        /// <value></value>
        public string Family { get; }
        public string Species { get; }


        /// <summary>
        ///     Constructs a new instance of Creature.
        /// </summary>
        /// <param name="family"></param>
        /// <param name="species"></param>
        public Creature(string family, string species)
        {
            Family = family ?? throw new ArgumentNullException(nameof(family));
            Species = species ?? throw new ArgumentNullException(nameof(species));
        }
    }
}