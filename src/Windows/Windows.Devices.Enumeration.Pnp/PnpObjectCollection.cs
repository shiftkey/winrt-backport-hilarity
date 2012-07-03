using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration.Pnp
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PnpObjectCollection : IVectorView<PnpObject>, IIterable<PnpObject>
	{
		public extern uint Size
		{
			get;
		}
		public extern PnpObject GetAt([In] uint index);
		public extern bool IndexOf([In] PnpObject value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] PnpObject[] items);
		public extern IIterator<PnpObject> First();
	}
}
