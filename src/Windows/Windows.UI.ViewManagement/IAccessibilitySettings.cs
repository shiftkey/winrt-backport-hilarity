using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[ExclusiveTo(typeof(AccessibilitySettings)), Guid(4262363463u, 50368, 17762, 185, 98, 19, 39, 181, 42, 213, 185), Version(100794368u)]
	internal interface IAccessibilitySettings
	{
		event TypedEventHandler<AccessibilitySettings, object> HighContrastChanged;
		bool HighContrast
		{
			get;
		}
		string HighContrastScheme
		{
			get;
		}
	}
}
