using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
	public interface IIterator<T>
	{
		T Current { get; } 
		bool HasCurrent { get; }
		bool MoveNext();
		uint GetMany([LengthIs(0)] [Out] T[] items);
	}

    internal class IteratorShim<T> : IIterator<T>
    {
        readonly IEnumerator<T> enumerator;

        internal IteratorShim(IEnumerator<T> enumerator)
        {
            this.enumerator = enumerator;
        }

        public T Current
        {
            get { return enumerator.Current; }
        }
        public bool HasCurrent
        {
            get { return default(T).Equals(enumerator.Current); }
        }

        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }

        public uint GetMany(T[] items)
        {
            throw new NotImplementedException("what the fuck is this shit");
        }
    }
}
