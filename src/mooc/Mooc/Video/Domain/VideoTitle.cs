namespace Mooc.Video.Domain
{
    public sealed class VideoTitle
    {
        public string Value { get; }

        public VideoTitle(string value)
        {
            Value = value;
        }

        private bool Equals(VideoTitle other)
        {
            return string.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((VideoTitle) obj);
        }

        public override int GetHashCode()
        {
            return (Value != null ? Value.GetHashCode() : 0);
        }
    }
}