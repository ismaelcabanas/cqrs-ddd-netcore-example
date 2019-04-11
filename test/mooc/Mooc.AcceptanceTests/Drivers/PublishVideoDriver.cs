using System.Collections.Generic;
using FluentAssertions;
using Mooc.Video.Application.Publish;
using Mooc.Video.Domain;
using Shared.Domain;

namespace Mooc.AcceptanceTests.Drivers
{
    public class PublishVideoDriver
    {
        private string _videoTitle;
        private string _videoDescription;
        private readonly VideoPublisher _videoPublisher;
        private readonly EventBusStub _eventBus;

        public PublishVideoDriver()
        {
            _eventBus = new EventBusStub();
            _videoPublisher = new VideoPublisher(_eventBus);
        }
        public void Publish()
        {
            _videoPublisher.Publish(_videoTitle, _videoDescription);
        }

        public void Title(string title)
        {
            _videoTitle = title;
        }

        public void Description(string description)
        {
            _videoDescription = description;
        }

        public void IsVideoPublished()
        {
            _eventBus.ShouldHavePublishedVideo(_videoTitle, _videoDescription);            
        }
    }

    internal class EventBusStub : EventBus
    {
        private readonly List<DomainEvent> _events = new List<DomainEvent>();
        public void Publish(List<DomainEvent> events)
        {
            _events.AddRange(events);
        }        

        public void ShouldHavePublishedVideo(string title, string description)
        {
            _events.Should().Contain(new List<DomainEvent>
            {
                new VideoPublished(title, description)
            });
        }
    }
}