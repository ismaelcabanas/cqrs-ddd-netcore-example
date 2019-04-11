namespace Mooc.Video.Domain
{
    public sealed class VideoDescription
    {
        public string Value { get; }

        public VideoDescription(string value)
        {
            Value = value;
        }

        private bool Equals(VideoDescription other)
        {
            return string.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((VideoDescription) obj);
        }

        public override int GetHashCode()
        {
            return (Value != null ? Value.GetHashCode() : 0);
        }
    }
}