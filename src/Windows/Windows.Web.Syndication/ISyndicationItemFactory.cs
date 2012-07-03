using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationItem)), Guid(622674767u, 32184, 18554, 133, 228, 16, 209, 145, 230, 110, 187), Version(100794368u)]
	internal interface ISyndicationItemFactory
	{
		SyndicationItem CreateSyndicationItem([In] string title, [In] SyndicationContent content, [In] Uri uri);
	}
}
