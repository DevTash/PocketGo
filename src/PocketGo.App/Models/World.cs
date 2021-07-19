using System;
using System.Collections.Generic;

namespace PocketGo.App.Models
{
    /// <summary>
    ///     Represents the PocketGo world.
    /// </summary>
    public class World
    {
        /// <summary>
        ///     Trainers in this PocketGo world.
        /// </summary>
        /// <value></value>
        public Dictionary<Guid, Trainer> Trainers { get; private set; }

        /// <summary>
        ///     Creatures in this PocketGo world.
        /// </summary>
        /// <value></value>
        public Dictionary<Guid, Creature> Creatures { get; private set; }

        /// <summary>
        ///     Constructs a new instance of a PocketGo world.
        /// </summary>
        public World()
        {
            Trainers = new Dictionary<Guid, Trainer>();
            Creatures = new Dictionary<Guid, Creature>();
        }

        /// <summary>
        ///     Add a Trainer to this PocketGo world.
        /// </summary>
        /// <param name="trainer"></param>
        public void AddTrainer(Trainer trainer)
        {
            Trainers.TryAdd(trainer.Id, trainer);
        }

        /// <summary>
        ///     Remove a Trainer from this PocketGo world.
        /// </summary>
        /// <param name="trainerId"></param>
        public void RemoveTrainer(Guid trainerId)
        {
            if (Trainers.ContainsKey(trainerId))
            {
                Trainers.Remove(trainerId);
            }
        }

        /// <summary>
        ///     Add a Creature to this PocketGo world.
        /// </summary>
        /// <param name="creature"></param>
        public void AddCreature(Creature creature)
        {
            Creatures.TryAdd(creature.Id, creature);
        }

        /// <summary>
        ///     Remove a Creature from this PocketGo world.
        /// </summary>
        /// <param name="creatureId"></param>
        public void RemoveCreature(Guid creatureId)
        {
            if (Creatures.ContainsKey(creatureId))
            {
                Creatures.Remove(creatureId);
            }
        }
    }
}