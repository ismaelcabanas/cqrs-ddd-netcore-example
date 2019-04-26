using Mooc.Video.Domain;
using Shared.Domain;

namespace Mooc.Video.Application.Publish
{
    public class VideoPublisher
    {
        private readonly EventBus _eventBus;
        public VideoPublisher(EventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Publish(string videoTitle, string videoDescription)
        {
            var video = Domain.Video.Publish(new VideoTitle(videoTitle), new VideoDescription(videoDescription));
            
            _eventBus.Publish(video.PullDomainEvents());
        }
    }
}