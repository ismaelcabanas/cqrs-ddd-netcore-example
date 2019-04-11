using Shared.Domain;

namespace Mooc.Video.Domain
{
    public sealed class Video : AggregateRoot
    {
        public VideoTitle VideoTitle { get; }
        public VideoDescription VideoDescription { get; }

        public Video(VideoTitle videoTitle, VideoDescription videoDescription)
        {
            VideoTitle = videoTitle;
            VideoDescription = videoDescription;
        }

        public static Video Publish(VideoTitle videoTitle, VideoDescription videoDescription)
        {
            Video video = new Video(videoTitle, videoDescription);
            
            video.Record(new VideoPublished(videoTitle.Value, videoDescription.Value));
            
            return video;
        }
    }
}