using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Search
{
	[ExclusiveTo(typeof(SearchPaneVisibilityChangedEventArgs)), Guid(1011691590u, 44107, 18930, 151, 214, 2, 14, 97, 130, 203, 156), Version(100794368u)]
	internal interface ISearchPaneVisibilityChangedEventArgs
	{
		bool Visible
		{
			get;
		}
	}
}
