using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class NamedResource : INamedResource
	{
		public extern IVectorView<ResourceCandidate> Candidates
		{
			get;
		}
		public extern Uri Uri
		{
			get;
		}
		[Overload("Resolve")]
		public extern ResourceCandidate Resolve();
		[Overload("ResolveForContext")]
		public extern ResourceCandidate Resolve([In] ResourceContext resourceContext);
		[Overload("ResolveAll")]
		public extern IVectorView<ResourceCandidate> ResolveAll();
		[Overload("ResolveAllForContext")]
		public extern IVectorView<ResourceCandidate> ResolveAll([In] ResourceContext resourceContext);
	}
}
