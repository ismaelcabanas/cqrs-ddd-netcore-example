using System;
using Shared.Domain.Bus.Commands;

namespace Shared.Tests.Fakes
{
    public sealed class SomeCommand : Command
    {
        public SomeCommand(Guid messageId) : base(messageId)
        {
        }
    }
}