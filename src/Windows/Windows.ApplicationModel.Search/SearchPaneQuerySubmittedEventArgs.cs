using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SearchPaneQuerySubmittedEventArgs : ISearchPaneQuerySubmittedEventArgs
	{
		public extern string Language
		{
			get;
		}
		public extern string QueryText
		{
			get;
		}
	}
}
