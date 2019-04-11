using FluentAssertions;
using Mooc.Video.Domain;
using Xunit;

namespace Mooc.Tests.Video.Domain.Model
{
    public sealed class VideoTitleShould
    {

        private static readonly string SomeVideoTitle = "some video title";
        private static readonly string AnotherVideoTitle = "another video title";
        
        [Fact]
        public void Return_True_When_Compare_VideoTitle_With_Same_Value()
        {
            // given
            VideoTitle videoTitleOne = new VideoTitle(SomeVideoTitle);
            VideoTitle videoTitleTwo = new VideoTitle(SomeVideoTitle);
            
            // when
            bool result = videoTitleOne.Equals(videoTitleTwo);
            
            // then
            result.Should().BeTrue();
        }
        
        [Fact]
        public void Return_False_When_Compare_VideoTitle_With_Different_Value()
        {
            // given
            VideoTitle videoTitleOne = new VideoTitle(SomeVideoTitle);
            VideoTitle videoTitleTwo = new VideoTitle(AnotherVideoTitle);
            
            // when
            bool result = videoTitleOne.Equals(videoTitleTwo);
            
            // then
            result.Should().BeFalse();
        }
        
        [Fact]
        public void Return_False_When_Compare_VideoTitle_With_Null_Value()
        {
            // given
            VideoTitle videoTitleOne = new VideoTitle(SomeVideoTitle);
            
            // when
            bool result = videoTitleOne.Equals(null);
            
            // then
            result.Should().BeFalse();
        }
        
    }
}