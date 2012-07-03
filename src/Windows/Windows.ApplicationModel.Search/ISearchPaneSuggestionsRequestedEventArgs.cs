using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchPaneSuggestionsRequestedEventArgs)), Guid(3365636655u, 44118, 17504, 141, 47, 128, 2, 59, 236, 79, 197), Version(100794368u)]
	internal interface ISearchPaneSuggestionsRequestedEventArgs : ISearchPaneQueryChangedEventArgs
	{
		SearchPaneSuggestionsRequest Request
		{
			get;
		}
	}
}
