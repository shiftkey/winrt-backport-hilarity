using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[ExclusiveTo(typeof(NamedResource)), Guid(479773209u, 2835, 16960, 137, 165, 212, 149, 220, 24, 154, 0), Version(100794368u)]
	internal interface INamedResource
	{
		IVectorView<ResourceCandidate> Candidates
		{
			get;
		}
		Uri Uri
		{
			get;
		}
		[Overload("Resolve")]
		ResourceCandidate Resolve();
		[Overload("ResolveForContext")]
		ResourceCandidate Resolve([In] ResourceContext resourceContext);
		[Overload("ResolveAll")]
		IVectorView<ResourceCandidate> ResolveAll();
		[Overload("ResolveAllForContext")]
		IVectorView<ResourceCandidate> ResolveAll([In] ResourceContext resourceContext);
	}
}
