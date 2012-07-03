using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SearchPaneSuggestionsRequest : ISearchPaneSuggestionsRequest
	{
		public extern bool IsCanceled
		{
			get;
		}
		public extern SearchSuggestionCollection SearchSuggestionCollection
		{
			get;
		}
		public extern SearchPaneSuggestionsRequestDeferral GetDeferral();
	}
}
