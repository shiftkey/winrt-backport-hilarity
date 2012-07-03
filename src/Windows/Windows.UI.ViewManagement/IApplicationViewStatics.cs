using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[ExclusiveTo(typeof(ApplicationView)), Guid(17457926u, 50227, 17637, 169, 242, 189, 132, 212, 3, 10, 149), Version(100794368u)]
	internal interface IApplicationViewStatics
	{
		ApplicationViewState Value
		{
			get;
		}
		bool TryUnsnap();
	}
}
