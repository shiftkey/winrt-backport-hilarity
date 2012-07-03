using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class AccessibilitySettings : IAccessibilitySettings
	{
		public extern event TypedEventHandler<AccessibilitySettings, object> HighContrastChanged
		{
			add;
			remove;
		}
		public extern bool HighContrast
		{
			get;
		}
		public extern string HighContrastScheme
		{
			get;
		}
		public extern AccessibilitySettings();
	}
}
