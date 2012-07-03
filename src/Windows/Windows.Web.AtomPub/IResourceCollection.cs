using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;
namespace Windows.Web.AtomPub
{
	[ExclusiveTo(typeof(ResourceCollection)), Guid(2136987145u, 48264, 16852, 136, 250, 61, 230, 112, 77, 66, 142), Version(100794368u)]
	internal interface IResourceCollection : ISyndicationNode
	{
		IVectorView<string> Accepts
		{
			get;
		}
		IVectorView<SyndicationCategory> Categories
		{
			get;
		}
		ISyndicationText Title
		{
			get;
		}
		Uri Uri
		{
			get;
		}
	}
}
