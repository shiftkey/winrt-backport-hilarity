using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchSuggestionCollection)), Guid(842697291u, 64490, 17478, 171, 188, 61, 167, 145, 95, 221, 58), Version(100794368u)]
	internal interface ISearchSuggestionCollection
	{
		uint Size
		{
			get;
		}
		void AppendQuerySuggestion([In] string text);
		void AppendQuerySuggestions([In] IIterable<string> suggestions);
		void AppendResultSuggestion([In] string text, [In] string detailText, [In] string tag, [In] IRandomAccessStreamReference image, [In] string imageAlternateText);
		void AppendSearchSeparator([In] string label);
	}
}
