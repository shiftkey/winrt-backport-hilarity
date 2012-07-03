using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationLink)), Guid(659897021u, 41230, 16821, 134, 189, 151, 89, 8, 110, 176, 197), Version(100794368u)]
	internal interface ISyndicationLink : ISyndicationNode
	{
		uint Length
		{
			get;
			set;
		}
		string MediaType
		{
			get;
			set;
		}
		string Relationship
		{
			get;
			set;
		}
		string ResourceLanguage
		{
			get;
			set;
		}
		string Title
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
