using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Mooc.Video.Application.Publish;
using Mooc.Video.Domain;
using Shared.Domain;
using Xunit;

namespace Mooc.Tests.Video.Application.Publish
{
    public class VideoPublisherShould
    {
        [Fact]
        void publish_the_video_published_domain_event() {
            // given
            EventBusStub eventBus = new EventBusStub();
            var videoPublisher = new VideoPublisher(eventBus);
            var videoTitle = "\uD83C\uDF89 New YouTube.com/CodelyTV video title";
            var videoDescription = "This should be the video description \uD83D\uDE42";

            // when
            videoPublisher.Publish(videoTitle, videoDescription);

            // then
            var expectedVideoCreated = new VideoPublished(videoTitle, videoDescription);
            eventBus.ShouldHavePublished(expectedVideoCreated);            
        }
    }

    internal class EventBusStub : EventBus
    {
        public void Publish(List<DomainEvent> events)
        {
            //throw new System.NotImplementedException();
        }

        public void ShouldHavePublished(VideoPublished expectedVideoCreated)
        {
            //throw new System.NotImplementedException();
        }
    }
}