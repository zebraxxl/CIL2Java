using CIL2Java;
using System.Collections;

namespace System.Collections.Generic
{
    /// <summary>Provides a base class for implementations of the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> generic interface.</summary><typeparam name="T">The type of objects to compare.</typeparam>
    [Serializable]
    public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
    {
        private static volatile EqualityComparer<T> defaultComparer;
    
        /// <summary>Returns a default equality comparer for the type specified by the generic argument.</summary><returns>The default instance of the <see cref="T:System.Collections.Generic.EqualityComparer`1" /> class for type <paramref name="T" />.</returns>
        public static EqualityComparer<T> Default
        {
            get
            {
                var comparer = defaultComparer;
                if (comparer == null)
                {
                    comparer = CreateDefaultComparer();
                    defaultComparer = comparer;
                }
                return comparer;
            }
        }

        private static EqualityComparer<T> CreateDefaultComparer()
        {
            if (typeof(T) == typeof(String))
                return (EqualityComparer<T>)Intrinsics.UnsafeTypeConvert(new StringsEqualityComparer());

            if (typeof(T) == typeof(Int32))
                return (EqualityComparer<T>)Intrinsics.UnsafeTypeConvert(new Int32EqualityComparer());

            if (typeof(T) == typeof(Byte))
                return (EqualityComparer<T>)Intrinsics.UnsafeTypeConvert(new ByteEqualityComparer());

            if (typeof(T) == typeof(Int16))
                return (EqualityComparer<T>)Intrinsics.UnsafeTypeConvert(new Int16EqualityComparer());

            if (typeof(T) == typeof(Int64))
                return (EqualityComparer<T>)Intrinsics.UnsafeTypeConvert(new Int64EqualityComparer());

            if (typeof(T) == typeof(SByte))
                return (EqualityComparer<T>)Intrinsics.UnsafeTypeConvert(new SByteEqualityComparer());

            if (typeof(T) == typeof(UInt16))
                return (EqualityComparer<T>)Intrinsics.UnsafeTypeConvert(new UInt16EqualityComparer());

            if (typeof(T) == typeof(UInt32))
                return (EqualityComparer<T>)Intrinsics.UnsafeTypeConvert(new UInt32EqualityComparer());

            if (typeof(T) == typeof(UInt64))
                return (EqualityComparer<T>)Intrinsics.UnsafeTypeConvert(new UInt64EqualityComparer());

            return new DefaultEqualityComparer<T>();
        }
    
    
        public abstract bool Equals(T x, T y);
        public abstract int GetHashCode(T obj);

        bool IEqualityComparer.Equals(object x, object y)
        {
            if (x == y) return true;
            if ((x == null) || (y == null)) return false;
            if ((x is T) && (y is T)) return Equals((T)x, (T)y);
            ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
            return false;
        }

        int IEqualityComparer.GetHashCode(object obj)
        {
            if (obj == null) return 0;
            if (obj is T) return GetHashCode((T)obj);
            ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
            return 0;    
        }
    }

    internal sealed class DefaultEqualityComparer<T> : EqualityComparer<T>
    {
        public override bool Equals(T x, T y)
        {
            if (x == null)
                return (y == null);
            return x.Equals(y);
        }

        public override int GetHashCode(T obj)
        {
            if (obj == null)
                return 0;
            return obj.GetHashCode();
        }
    }

    internal sealed class StringsEqualityComparer : EqualityComparer<string>
    {
        public override bool Equals(string x, string y)
        {
            if (x == null)
                return (y == null);
            if (((object)x) == (object)y)
                return true;
            return x == y;
        }

        public override int GetHashCode(string obj)
        {
            if (obj == null)
                return 0;
            return obj.GetHashCode();
        }
    }

    internal sealed class SByteEqualityComparer : EqualityComparer<sbyte>
    {
        public override bool Equals(sbyte x, sbyte y)
        {
            return x == y;
        }

        public override int GetHashCode(sbyte obj)
        {
            return obj;
        }
    }

    internal sealed class Int16EqualityComparer : EqualityComparer<short>
    {
        public override bool Equals(short x, short y)
        {
            return x == y;
        }

        public override int GetHashCode(short obj)
        {
            return obj;
        }
    }

    internal sealed class Int32EqualityComparer : EqualityComparer<int>
    {
        public override bool Equals(int x, int y)
        {
            return x == y;
        }

        public override int GetHashCode(int obj)
        {
            return obj;
        }
    }

    internal sealed class Int64EqualityComparer : EqualityComparer<long>
    {
        public override bool Equals(long x, long y)
        {
            return x == y;
        }

        public override int GetHashCode(long obj)
        {
            return ((int)obj) ^ (int)(obj >> 32);
        }
    }

    internal sealed class ByteEqualityComparer : EqualityComparer<byte>
    {
        public override bool Equals(byte x, byte y)
        {
            return x == y;
        }

        public override int GetHashCode(byte obj)
        {
            return obj;
        }
    }

    internal sealed class UInt16EqualityComparer : EqualityComparer<ushort>
    {
        public override bool Equals(ushort x, ushort y)
        {
            return x == y;
        }

        public override int GetHashCode(ushort obj)
        {
            return obj;
        }
    }

    internal sealed class UInt32EqualityComparer : EqualityComparer<uint>
    {
        public override bool Equals(uint x, uint y)
        {
            return x == y;
        }

        public override int GetHashCode(uint obj)
        {
            return unchecked((int)obj);
        }
    }

    internal sealed class UInt64EqualityComparer : EqualityComparer<ulong>
    {
        public override bool Equals(ulong x, ulong y)
        {
            return x == y;
        }

        public override int GetHashCode(ulong obj)
        {
            return ((int)obj) ^ (int)(obj >> 32);
        }
    }
}
