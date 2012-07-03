using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[ExclusiveTo(typeof(InputPane)), Guid(2515840826u, 61255, 16970, 151, 65, 253, 40, 21, 235, 162, 189), Version(100794368u)]
	internal interface IInputPaneStatics
	{
		InputPane GetForCurrentView();
	}
}
