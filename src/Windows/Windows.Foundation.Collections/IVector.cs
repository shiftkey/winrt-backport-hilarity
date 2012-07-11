using System.Collections.Generic;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
	public interface IVector<T> : IIterable<T>
	{
		uint Size { get; }
		T GetAt([In] uint index);
		IVectorView<T> GetView();
		bool IndexOf([In] T value, out uint index);
		void SetAt([In] uint index, [In] T value);
		void InsertAt([In] uint index, [In] T value);
		void RemoveAt([In] uint index);
		void Append([In] T value);
		void RemoveAtEnd();
		void Clear();
		uint GetMany([In] uint startIndex, [LengthIs(0)] [Out] T[] items);
		void ReplaceAll([In] T[] items);
	}

    public class VectorShim<T> : IVector<T>
    {
        private readonly IList<T> list;

        public VectorShim(IList<T> list)
        {
            this.list = list;
        }

        public IIterator<T> First()
        {
            return new IteratorShim<T>(list.GetEnumerator());
        }

        public uint Size
        {
            get { return (uint)list.Count; }
        }

        public T GetAt(uint index)
        {
            return list[(int) index];
        }

        public IVectorView<T> GetView()
        {
            throw new System.NotImplementedException();
        }

        public bool IndexOf(T value, out uint index)
        {
            if (list.Contains(value))
            {
                index = (uint)list.IndexOf(value);
                return true;
            }
            index = default(uint);
            return false;
        }

        public void SetAt(uint index, T value)
        {
            list[(int) index] = value;
        }

        public void InsertAt(uint index, T value)
        {
            list[(int)index] = value;
        }

        public void RemoveAt(uint index)
        {
            list.RemoveAt((int) index);
        }

        public void Append(T value)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAtEnd()
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public uint GetMany(uint startIndex, T[] items)
        {
            throw new System.NotImplementedException();
        }

        public void ReplaceAll(T[] items)
        {
            throw new System.NotImplementedException();
        }
    }
}
