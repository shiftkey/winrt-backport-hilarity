using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationFeed)), Guid(591864370u, 35817, 18615, 137, 52, 98, 5, 19, 29, 147, 87), Version(100794368u)]
	internal interface ISyndicationFeedFactory
	{
		SyndicationFeed CreateSyndicationFeed([In] string title, [In] string subtitle, [In] Uri uri);
	}
}
