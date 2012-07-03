using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SearchPaneResultSuggestionChosenEventArgs : ISearchPaneResultSuggestionChosenEventArgs
	{
		public extern string Tag
		{
			get;
		}
	}
}
