using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationAttribute)), Guid(1649350041u, 60734, 16911, 190, 134, 100, 4, 20, 136, 110, 75), Version(100794368u)]
	internal interface ISyndicationAttributeFactory
	{
		SyndicationAttribute CreateSyndicationAttribute([In] string attributeName, [In] string attributeNamespace, [In] string attributeValue);
	}
}
