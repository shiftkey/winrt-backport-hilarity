using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ApplicationSettings
{
	[MarshalingBehavior(MarshalingType.None), Static(typeof(ISettingsPaneStatics), 100794368u), Version(100794368u)]
	public sealed class SettingsPane : ISettingsPane
	{
		public extern event TypedEventHandler<SettingsPane, SettingsPaneCommandsRequestedEventArgs> CommandsRequested
		{
			add;
			remove;
		}
		public static extern SettingsPane GetForCurrentView();
		public static extern void Show();
	}
}
