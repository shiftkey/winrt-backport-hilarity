using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;
namespace Windows.UI.ApplicationSettings
{
	[ExclusiveTo(typeof(SettingsCommand)), Guid(1759599411u, 7299, 17210, 170, 90, 206, 238, 165, 189, 71, 100), Version(100794368u)]
	internal interface ISettingsCommandFactory
	{
		[DefaultOverload, Overload("CreateSettingsCommand")]
		SettingsCommand Create([Variant] [In] object settingsCommandId, [In] string label, [In] UICommandInvokedHandler handler);
	}
}
