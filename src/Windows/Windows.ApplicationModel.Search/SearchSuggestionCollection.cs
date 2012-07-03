using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.Search
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SearchSuggestionCollection : ISearchSuggestionCollection
	{
		public extern uint Size
		{
			get;
		}
		public extern void AppendQuerySuggestion([In] string text);
		public extern void AppendQuerySuggestions([In] IIterable<string> suggestions);
		public extern void AppendResultSuggestion([In] string text, [In] string detailText, [In] string tag, [In] IRandomAccessStreamReference image, [In] string imageAlternateText);
		public extern void AppendSearchSeparator([In] string label);
	}
}
