using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Version(100794368u)]
	public enum ActivationKind
	{
		Launch,
		Search,
		ShareTarget,
		File,
		Protocol,
		FileOpenPicker,
		FileSavePicker,
		CachedFileUpdater,
		ContactPicker,
		Device,
		PrintTaskSettings,
		CameraSettings
	}
}
