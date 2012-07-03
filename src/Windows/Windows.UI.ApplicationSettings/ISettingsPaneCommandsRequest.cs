using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.ApplicationSettings
{
	[ExclusiveTo(typeof(SettingsPaneCommandsRequest)), Guid(1155474350u, 23918, 16488, 161, 104, 244, 118, 67, 24, 33, 20), Version(100794368u)]
	internal interface ISettingsPaneCommandsRequest
	{
		IVector<SettingsCommand> ApplicationCommands
		{
			get;
		}
	}
}
