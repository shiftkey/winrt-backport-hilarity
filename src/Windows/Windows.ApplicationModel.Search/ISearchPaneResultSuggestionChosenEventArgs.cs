using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchPaneResultSuggestionChosenEventArgs)), Guid(3358682304u, 44754, 16864, 188, 224, 194, 108, 167, 79, 133, 236), Version(100794368u)]
	internal interface ISearchPaneResultSuggestionChosenEventArgs
	{
		string Tag
		{
			get;
		}
	}
}
