using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationContent)), Guid(1178730238u, 3669, 16592, 184, 208, 106, 44, 203, 169, 252, 124), Version(100794368u)]
	internal interface ISyndicationContent : ISyndicationText, ISyndicationNode
	{
		Uri SourceUri
		{
			get;
			set;
		}
	}
}
