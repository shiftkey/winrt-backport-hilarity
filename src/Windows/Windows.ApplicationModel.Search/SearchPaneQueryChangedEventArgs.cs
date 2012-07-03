using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SearchPaneQueryChangedEventArgs : ISearchPaneQueryChangedEventArgs
	{
		public extern string Language
		{
			get;
		}
		public extern SearchPaneQueryLinguisticDetails LinguisticDetails
		{
			get;
		}
		public extern string QueryText
		{
			get;
		}
	}
}
