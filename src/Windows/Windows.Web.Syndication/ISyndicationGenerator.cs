using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationGenerator)), Guid(2540221305u, 64299, 20333, 180, 28, 8, 138, 88, 104, 130, 92), Version(100794368u)]
	internal interface ISyndicationGenerator
	{
		string Text
		{
			get;
			set;
		}
		Uri Uri
		{
			get;
			set;
		}
		string Version
		{
			get;
			set;
		}
	}
}
