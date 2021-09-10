using System;

namespace WolvenKit.RED4.Types
{
    [RED("multiChannelCurve")]
    public class MultiChannelCurve<T> : IRedMultiChannelCurve<T>, IEquatable<MultiChannelCurve<T>> where T : IRedType
    {
        public uint NumChannels { get; set; }
        public Enums.EInterPolationType InterPolationType { get; set; }
        public Enums.EChannelLinkType LinkType { get; set; }
        public uint Alignment { get; set; }
        public byte[] Data { get; set; }

        public bool Equals(MultiChannelCurve<T> other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return NumChannels == other.NumChannels && InterPolationType == other.InterPolationType && LinkType == other.LinkType && Alignment == other.Alignment && Equals(Data, other.Data);
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

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((MultiChannelCurve<T>)obj);
        }

        public override int GetHashCode() => HashCode.Combine(NumChannels, (byte)InterPolationType, (byte)LinkType, Alignment, Data);
    }
}
