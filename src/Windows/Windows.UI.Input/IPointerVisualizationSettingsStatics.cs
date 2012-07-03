using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(PointerVisualizationSettings)), Guid(1753681627u, 5723, 16916, 180, 243, 88, 78, 202, 140, 138, 105), Version(100794368u)]
	internal interface IPointerVisualizationSettingsStatics
	{
		PointerVisualizationSettings GetForCurrentView();
	}
}
