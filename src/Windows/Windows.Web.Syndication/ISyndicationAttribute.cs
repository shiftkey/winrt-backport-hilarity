using System;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationAttribute)), Guid(1911093609u, 21102, 16385, 154, 145, 232, 79, 131, 22, 26, 177), Version(100794368u)]
	internal interface ISyndicationAttribute
	{
		string Name
		{
			get;
			set;
		}
		string Namespace
		{
			get;
			set;
		}
		string Value
		{
			get;
			set;
		}
	}
}
