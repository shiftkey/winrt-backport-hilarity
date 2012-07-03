using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchPaneSuggestionsRequest)), Guid(2175863580u, 58721, 16531, 155, 77, 42, 212, 130, 121, 74, 83), Version(100794368u)]
	internal interface ISearchPaneSuggestionsRequest
	{
		bool IsCanceled
		{
			get;
		}
		SearchSuggestionCollection SearchSuggestionCollection
		{
			get;
		}
		SearchPaneSuggestionsRequestDeferral GetDeferral();
	}
}
