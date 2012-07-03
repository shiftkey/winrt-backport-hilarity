using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.ApplicationSettings
{
	[MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class SettingsPaneCommandsRequest : ISettingsPaneCommandsRequest
	{
		public extern IVector<SettingsCommand> ApplicationCommands
		{
			get;
		}
	}
}
