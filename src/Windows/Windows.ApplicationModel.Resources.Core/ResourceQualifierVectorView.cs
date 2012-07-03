using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceQualifierVectorView : IVectorView<ResourceQualifier>, IIterable<ResourceQualifier>
	{
		public extern uint Size
		{
			get;
		}
		public extern ResourceQualifier GetAt([In] uint index);
		public extern bool IndexOf([In] ResourceQualifier value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] ResourceQualifier[] items);
		public extern IIterator<ResourceQualifier> First();
	}
}
