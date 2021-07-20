using System;
using System.Collections.Generic;
using FluentAssertions;
using FluentAssertions.Execution;
using PocketGo.App.Models;
using Xunit;

namespace PocketGo.App.Tests.Models
{
    public class WorldTests
    {
        private readonly World _sut;

        public WorldTests()
        {
            _sut = new World();
        }

        [Fact]
        public void Given_World_Constructor_Is_Invoked_Then_Trainers_Is_Initialized()
        {
            // Arrange
            // Act
            var world = new World();
            
            // Assert
            using (new AssertionScope())
            {
                world.Trainers.Should().NotBeNull();
                world.Trainers.Should().BeOfType<Dictionary<Guid, Trainer>>();
            }            
        }

        [Fact]
        public void Given_World_Constructor_Is_Invoked_Then_Creatures_Is_Initialized()
        {
            // Arrange
            // Act
            var world = new World();

            // Assert
            using (new AssertionScope())
            {
                world.Creatures.Should().NotBeNull();
                world.Creatures.Should().BeOfType<Dictionary<Guid, Creature>>();
            }

        }

        [Fact]
        public void Given_Trainer_Then_AddTrainer_Adds_Trainer_To_Trainers()
        {
            // Arrange
            var trainer = new Trainer();

            // Act
            _sut.AddTrainer(trainer);


            // Assert
            using (new AssertionScope())
            {
                _sut.Trainers.Should().ContainKey(trainer.Id).WhichValue
                         .Should().BeEquivalentTo(trainer);
            }
        }

        [Fact]
        public void Given_Trainer_Id_Then_RemoveTrainer_Removes_Trainer_From_Trainers()
        {
            // Arrange
            var trainer = new Trainer();

            _sut.AddTrainer(trainer);

            // Act
            _sut.RemoveTrainer(trainer.Id);

            // Assert
            _sut.Trainers.Should().BeEmpty();

        }

        [Fact]
        public void Given_Creature_Then_AddCreature_Adds_Creature_To_Creatures()
        {
            // Arrange
            var creature = new Creature("flying", "Charblander");

            // Act
            _sut.AddCreature(creature);


            // Assert
            using (new AssertionScope())
            {
                _sut.Creatures.Should().ContainKey(creature.Id).WhichValue
                              .Should().BeEquivalentTo(creature);
            }
        }

        [Fact]
        public void Given_Creature_Id_Then_RemoveCreature_Removes_Creature_From_Creatures()
        {
            // Arrange
            var creature = new Creature("flying", "Charblander");

            _sut.AddCreature(creature);


            // Act
            _sut.RemoveCreature(creature.Id);


            // Assert
            _sut.Creatures.Should().BeEmpty();
        }
    }
}