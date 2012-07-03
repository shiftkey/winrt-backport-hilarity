using System;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationCategory)), Guid(2266325615u, 3258, 19071, 137, 255, 236, 181, 40, 20, 35, 182), Version(100794368u)]
	internal interface ISyndicationCategory : ISyndicationNode
	{
		string Label
		{
			get;
			set;
		}
		string Scheme
		{
			get;
			set;
		}
		string Term
		{
			get;
			set;
		}
	}
}
