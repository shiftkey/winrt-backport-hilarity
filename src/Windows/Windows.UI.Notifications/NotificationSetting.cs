using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Version(100794368u)]
	public enum NotificationSetting
	{
		Enabled,
		DisabledForApplication,
		DisabledForUser,
		DisabledByGroupPolicy,
		DisabledByManifest
	}
}
