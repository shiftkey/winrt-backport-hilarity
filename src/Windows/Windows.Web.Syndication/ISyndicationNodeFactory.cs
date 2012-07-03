using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationNode)), Guid(311435656u, 19147, 18856, 183, 119, 165, 235, 146, 225, 138, 121), Version(100794368u)]
	internal interface ISyndicationNodeFactory
	{
		SyndicationNode CreateSyndicationNode([In] string nodeName, [In] string nodeNamespace, [In] string nodeValue);
	}
}
