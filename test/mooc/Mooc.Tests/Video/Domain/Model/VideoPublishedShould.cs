using FluentAssertions;
using Mooc.Video.Domain;
using Xunit;

namespace Mooc.Tests.Video.Domain.Model
{
    public sealed class VideoPublishedShould
    {
        private static readonly string SomeVideoTitle = "some video title";
        private static readonly string AnotherVideoTitle = "another video title";
        private static readonly string SomeVideoDescription = "some video description";
        private static readonly string AnotherVideoDescription = "another video description";
        
        [Fact]
        public void Return_True_When_Compare_The_Same_VideoPublished_Event()
        {
            // given
            VideoPublished videoPublishedOne = new VideoPublished(SomeVideoTitle, SomeVideoDescription);
            VideoPublished videoPublishedTwo = new VideoPublished(SomeVideoTitle, SomeVideoDescription);
            
            // when
            bool result = videoPublishedOne.Equals(videoPublishedTwo);
            
            // then
            result.Should().BeTrue();
        }
        
        [Fact]
        public void Return_False_When_Compare_Different_VideoPublished_Event()
        {
            // given
            VideoPublished videoPublishedOne = new VideoPublished(SomeVideoTitle, SomeVideoDescription);
            VideoPublished videoPublishedTwo = new VideoPublished(AnotherVideoTitle, AnotherVideoDescription);
            
            // when
            bool result = videoPublishedOne.Equals(videoPublishedTwo);

            // then
            result.Should().BeFalse();
        }
        
        [Fact]
        public void Return_False_When_Compare_VideoPublished_Event_With_Null()
        {
            // given
            VideoPublished videoPublished = new VideoPublished(SomeVideoTitle, SomeVideoDescription);
            
            // when
            bool result = videoPublished.Equals(null);
            
            // then
            result.Should().BeFalse();
        }
    }
}