using System;
using System.Collections.Generic;
using Windows.Foundation.Collections;
using Xunit;

namespace Windows.Tests
{
    public class VectorShimTests
    {
        //void SetAt([In] uint index, [In] T value);
        //void InsertAt([In] uint index, [In] T value);
        //void RemoveAt([In] uint index);
        //void Append([In] T value);
        //void RemoveAtEnd();
        //void Clear();
        //uint GetMany([In] uint startIndex, [LengthIs(0)] [Out] T[] items);
        //void ReplaceAll([In] T[] items);

        readonly VectorShim<int> subject = new VectorShim<int>(new List<int> { 1, 2, 3 });

        [Fact]
        public void Size()
        {
            Assert.Equal<uint>(3, subject.Size);
        }

        [Fact]
        public void GetAt()
        {
            Assert.Equal(2, subject.GetAt(1));
        }

        [Fact]
        public void GetView()
        {
            Assert.Throws<NotImplementedException>(() => { subject.GetView(); });
        }

        [Fact]
        public void IndexOf_WhenFound_IsCorrect()
        {
            uint value;
            var result = subject.IndexOf(3, out value);

            Assert.True(result);
            Assert.Equal<uint>(2, value);
        }

        [Fact]
        public void IndexOf_WhenNotFound_IsCorrect()
        {
            uint value;
            var result = subject.IndexOf(4, out value);

            Assert.False(result);
            Assert.Equal(default(uint), value);
        }

        [Fact]
        public void SetAt_ForSimpleCase()
        {
            subject.SetAt(1, 4);

            uint value;
            subject.IndexOf(4, out value);

            Assert.Equal<uint>(1, value);
        }

        // TODO: more complex SetAt scenarios
        // TODO: invalid index
    }

}
