using System;
using Shared.Domain;

namespace Mooc.Video.Domain
{
    public sealed class VideoPublished : DomainEvent
    {
        private static readonly string FULL_QUALIFIED_EVENT_NAME = "codelytv.video.video.event.1.video.published";

        public string Title { get; private set; }
        public string Description { get; private set; }

        public VideoPublished(string title, string description) {
            Title = title;
            Description = description;
        }

        public string fullQualifiedEventName() {
            return FULL_QUALIFIED_EVENT_NAME;
        }

        public string title()
        {
            return Title;
        }

        public string description()
        {
            return Description;
        }

        private bool Equals(VideoPublished other)
        {
            return string.Equals(Title, other.Title) && string.Equals(Description, other.Description);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            return obj is VideoPublished other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Title != null ? Title.GetHashCode() : 0) * 397) ^ (Description != null ? Description.GetHashCode() : 0);
            }
        }
    }
}