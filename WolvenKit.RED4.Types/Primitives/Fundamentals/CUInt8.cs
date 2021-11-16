using System;
using System.Diagnostics;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [RED("Uint8")]
    [DebuggerDisplay("{_value,nq}", Type = "CUInt8")]
    public readonly struct CUInt8 : IRedPrimitive<byte>, IEquatable<CUInt8>, IRedInteger
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte _value;

        private CUInt8(byte value)
        {
            _value = value;
        }

        public static implicit operator CUInt8(byte value) => new(value);
        public static implicit operator byte(CUInt8 value) => value._value;

        public static CUInt8 operator +(CUInt8 objA, CUInt8 objB) => new((byte)(objA._value + objB._value));
        public static CUInt8 operator -(CUInt8 objA, CUInt8 objB) => new((byte)(objA._value - objB._value));
        public static CUInt8 operator *(CUInt8 objA, CUInt8 objB) => new((byte)(objA._value * objB._value));
        public static CUInt8 operator /(CUInt8 objA, CUInt8 objB) => new((byte)(objA._value / objB._value));


        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is CUInt8 cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CUInt8 other) => Equals(_value, other._value);
    }
}
