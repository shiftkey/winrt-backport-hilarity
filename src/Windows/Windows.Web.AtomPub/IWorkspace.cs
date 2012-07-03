using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;
namespace Windows.Web.AtomPub
{
	[ExclusiveTo(typeof(Workspace)), Guid(3021841979u, 42168, 16438, 137, 197, 131, 195, 18, 102, 186, 73), Version(100794368u)]
	internal interface IWorkspace : ISyndicationNode
	{
		IVectorView<ResourceCollection> Collections
		{
			get;
		}
		ISyndicationText Title
		{
			get;
		}
	}
}
