using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchPane)), Guid(4255968312u, 14080, 19827, 145, 161, 47, 153, 134, 116, 35, 138), Version(100794368u)]
	internal interface ISearchPane
	{
		event TypedEventHandler<SearchPane, SearchPaneQueryChangedEventArgs> QueryChanged;
		event TypedEventHandler<SearchPane, SearchPaneQuerySubmittedEventArgs> QuerySubmitted;
		event TypedEventHandler<SearchPane, SearchPaneResultSuggestionChosenEventArgs> ResultSuggestionChosen;
		event TypedEventHandler<SearchPane, SearchPaneSuggestionsRequestedEventArgs> SuggestionsRequested;
		event TypedEventHandler<SearchPane, SearchPaneVisibilityChangedEventArgs> VisibilityChanged;
		string Language
		{
			get;
		}
		string PlaceholderText
		{
			get;
			set;
		}
		string QueryText
		{
			get;
		}
		string SearchHistoryContext
		{
			get;
			set;
		}
		bool SearchHistoryEnabled
		{
			get;
			set;
		}
		bool Visible
		{
			get;
		}
		void SetLocalContentSuggestionSettings([In] LocalContentSuggestionSettings settings);
		[Overload("ShowOverloadDefault")]
		void Show();
		[Overload("ShowOverloadWithQuery")]
		void Show([In] string query);
	}
}
