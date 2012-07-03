using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchPaneSuggestionsRequestDeferral)), Guid(2697988599u, 34632, 20194, 173, 68, 175, 166, 190, 153, 124, 81), Version(100794368u)]
	internal interface ISearchPaneSuggestionsRequestDeferral
	{
		void Complete();
	}
}
