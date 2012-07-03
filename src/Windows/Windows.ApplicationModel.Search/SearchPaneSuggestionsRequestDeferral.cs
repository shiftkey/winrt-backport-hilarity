using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SearchPaneSuggestionsRequestDeferral : ISearchPaneSuggestionsRequestDeferral
	{
		public extern void Complete();
	}
}
