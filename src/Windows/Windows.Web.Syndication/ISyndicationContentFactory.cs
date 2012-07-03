using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationContent)), Guid(1026538387u, 38176, 16755, 147, 136, 126, 45, 243, 36, 168, 160), Version(100794368u)]
	internal interface ISyndicationContentFactory
	{
		[Overload("CreateSyndicationContent")]
		SyndicationContent CreateSyndicationContent([In] string text, [In] SyndicationTextType type);
		[Overload("CreateSyndicationContentWithSourceUri")]
		SyndicationContent CreateSyndicationContent([In] Uri sourceUri);
	}
}
