using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceCandidateVectorView : IVectorView<ResourceCandidate>, IIterable<ResourceCandidate>
	{
		public extern uint Size
		{
			get;
		}
		public extern ResourceCandidate GetAt([In] uint index);
		public extern bool IndexOf([In] ResourceCandidate value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] ResourceCandidate[] items);
		public extern IIterator<ResourceCandidate> First();
	}
}
