using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationText)), Guid(4000531191u, 4550, 19237, 171, 98, 229, 150, 189, 22, 41, 70), Version(100794368u)]
	internal interface ISyndicationTextFactory
	{
		[Overload("CreateSyndicationText")]
		SyndicationText CreateSyndicationText([In] string text);
		[Overload("CreateSyndicationTextEx")]
		SyndicationText CreateSyndicationText([In] string text, [In] SyndicationTextType type);
	}
}
