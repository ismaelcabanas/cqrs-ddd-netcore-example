using FluentAssertions;
using Mooc.Video.Domain;
using Xunit;

namespace Mooc.Tests.Video.Domain.Model
{
    public sealed class VideoDescriptionShould
    {
        private static readonly string SomeVideoDescription = "some video description";
        private static readonly string AnotherVideoDescription = "another video description";
        
        [Fact]
        public void Return_True_When_Compare_VideoDescription_With_Same_Value()
        {
            // given
            VideoDescription videoDescriptionOne = new VideoDescription(SomeVideoDescription);
            VideoDescription videoDescriptionTwo = new VideoDescription(SomeVideoDescription);
            
            // when
            bool result = videoDescriptionOne.Equals(videoDescriptionTwo);
            
            // then
            result.Should().BeTrue();
        }
        
        [Fact]
        public void Return_False_When_Compare_VideoDescription_With_Different_Value()
        {
            // given
            VideoDescription videoDescriptionOne = new VideoDescription(SomeVideoDescription);
            VideoDescription videoDescriptionTwo = new VideoDescription(AnotherVideoDescription);
            
            // when
            bool result = videoDescriptionOne.Equals(videoDescriptionTwo);
            
            // then
            result.Should().BeFalse();
        }
        
        [Fact]
        public void Return_False_When_Compare_VideoDescription_With_Null_Value()
        {
            // given
            VideoDescription videoDescriptionOne = new VideoDescription(SomeVideoDescription);
            
            // when
            bool result = videoDescriptionOne.Equals(null);
            
            // then
            result.Should().BeFalse();
        }
    }
}