using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ApplicationSettings
{
	[ExclusiveTo(typeof(SettingsPane)), Guid(2983004466u, 17776, 19561, 141, 56, 137, 68, 101, 97, 172, 224), Version(100794368u)]
	internal interface ISettingsPane
	{
		event TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs> CommandsRequested;
	}
}
