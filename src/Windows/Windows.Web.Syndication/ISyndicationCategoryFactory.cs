using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationCategory)), Guid(2873262127u, 18912, 17701, 138, 178, 171, 69, 192, 37, 40, 255), Version(100794368u)]
	internal interface ISyndicationCategoryFactory
	{
		[Overload("CreateSyndicationCategory")]
		SyndicationCategory CreateSyndicationCategory([In] string term);
		[Overload("CreateSyndicationCategoryEx")]
		SyndicationCategory CreateSyndicationCategory([In] string term, [In] string scheme, [In] string label);
	}
}
