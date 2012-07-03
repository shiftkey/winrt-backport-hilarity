using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationPerson)), Guid(4196328922u, 42950, 17687, 160, 150, 1, 67, 250, 242, 147, 39), Version(100794368u)]
	internal interface ISyndicationPerson : ISyndicationNode
	{
		string Email
		{
			get;
			set;
		}
		string Name
		{
			get;
			set;
		}
		Uri Uri
		{
			get;
			set;
		}
	}
}
