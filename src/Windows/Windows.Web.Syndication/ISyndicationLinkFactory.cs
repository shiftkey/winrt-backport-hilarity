using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationLink)), Guid(1591239636u, 21813, 18604, 152, 212, 193, 144, 153, 80, 128, 179), Version(100794368u)]
	internal interface ISyndicationLinkFactory
	{
		[Overload("CreateSyndicationLink")]
		SyndicationLink CreateSyndicationLink([In] Uri uri);
		[Overload("CreateSyndicationLinkEx")]
		SyndicationLink CreateSyndicationLink([In] Uri uri, [In] string relationship, [In] string title, [In] string mediaType, [In] uint length);
	}
}
