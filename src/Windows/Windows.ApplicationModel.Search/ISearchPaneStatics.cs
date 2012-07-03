using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchPane)), Guid(2507320817u, 36637, 18463, 161, 91, 198, 22, 85, 241, 106, 14), Version(100794368u)]
	internal interface ISearchPaneStatics
	{
		SearchPane GetForCurrentView();
	}
}
