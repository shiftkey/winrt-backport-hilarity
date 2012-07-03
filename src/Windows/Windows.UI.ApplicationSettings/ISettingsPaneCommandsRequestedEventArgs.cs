using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.ApplicationSettings
{
	[ExclusiveTo(typeof(SettingsPaneCommandsRequestedEventArgs)), Guid(543120676u, 6984, 17961, 166, 202, 47, 223, 237, 175, 183, 93), Version(100794368u)]
	internal interface ISettingsPaneCommandsRequestedEventArgs
	{
		SettingsPaneCommandsRequest Request
		{
			get;
		}
	}
}
