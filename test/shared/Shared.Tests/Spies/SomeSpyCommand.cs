using System;
using FluentAssertions;
using Shared.Domain.Bus.Commands;

namespace Shared.Tests.Spies
{
    public sealed class SomeSpyCommand : Command
    {
        public SomeSpyCommand() : base(Guid.NewGuid())
        {
        }

        public void ShouldBeCommandTypeMessage()
        {
            MessageType().Should().Be("command");
        }
    }
}