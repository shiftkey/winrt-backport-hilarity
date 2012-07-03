using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Activatable(typeof(IBufferFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Buffer : IBuffer
	{
		public extern uint Capacity
		{
			get;
		}
		public extern uint Length
		{
			get;
			set;
		}
		public extern Buffer([Range(0, 2147483647)] [In] uint capacity);
	}
}
