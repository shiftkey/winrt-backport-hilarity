using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;
namespace Windows.Web.AtomPub
{
	[ExclusiveTo(typeof(ServiceDocument)), Guid(2340341617u, 10931, 19902, 139, 204, 119, 143, 146, 183, 94, 81), Version(100794368u)]
	internal interface IServiceDocument : ISyndicationNode
	{
		IVectorView<Workspace> Workspaces
		{
			get;
		}
	}
}
