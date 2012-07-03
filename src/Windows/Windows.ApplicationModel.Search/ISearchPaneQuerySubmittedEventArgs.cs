using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchPaneQuerySubmittedEventArgs)), Guid(339453180u, 59845, 18230, 145, 178, 232, 235, 156, 184, 131, 86), Version(100794368u)]
	internal interface ISearchPaneQuerySubmittedEventArgs
	{
		string Language
		{
			get;
		}
		string QueryText
		{
			get;
		}
	}
}
