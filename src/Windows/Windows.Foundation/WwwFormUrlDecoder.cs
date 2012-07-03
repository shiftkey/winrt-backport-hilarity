using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Activatable(typeof(IWwwFormUrlDecoderRuntimeClassFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class WwwFormUrlDecoder : IWwwFormUrlDecoderRuntimeClass, IIterable<IWwwFormUrlDecoderEntry>, IVectorView<IWwwFormUrlDecoderEntry>
	{
		public extern uint Size
		{
			get;
		}
		public extern WwwFormUrlDecoder([In] string hstrWwwFormUrlDecoder);
		public extern string GetFirstValueByName([In] string name);
		public extern IIterator<IWwwFormUrlDecoderEntry> First();
		public extern IWwwFormUrlDecoderEntry GetAt([In] uint index);
		public extern bool IndexOf([In] IWwwFormUrlDecoderEntry value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] IWwwFormUrlDecoderEntry[] items);
	}
}
