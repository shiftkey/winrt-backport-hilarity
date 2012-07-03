using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.ApplicationSettings
{
	[MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class SettingsPaneCommandsRequestedEventArgs : ISettingsPaneCommandsRequestedEventArgs
	{
		public extern SettingsPaneCommandsRequest Request
		{
			get;
		}
	}
}
