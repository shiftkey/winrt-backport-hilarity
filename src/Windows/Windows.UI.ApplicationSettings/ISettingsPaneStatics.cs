using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.ApplicationSettings
{
	[ExclusiveTo(typeof(SettingsPane)), Guid(476730053u, 65305, 18203, 186, 107, 248, 243, 86, 148, 173, 154), Version(100794368u)]
	internal interface ISettingsPaneStatics
	{
		SettingsPane GetForCurrentView();
		void Show();
	}
}
