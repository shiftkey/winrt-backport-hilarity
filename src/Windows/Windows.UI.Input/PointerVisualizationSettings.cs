using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPointerVisualizationSettingsStatics), 100794368u), Version(100794368u)]
	public sealed class PointerVisualizationSettings : IPointerVisualizationSettings
	{
		public extern bool IsBarrelButtonFeedbackEnabled
		{
			get;
			set;
		}
		public extern bool IsContactFeedbackEnabled
		{
			get;
			set;
		}
		public static extern PointerVisualizationSettings GetForCurrentView();
	}
}
