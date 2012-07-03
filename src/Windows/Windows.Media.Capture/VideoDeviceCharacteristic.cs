using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[Version(100794368u)]
	public enum VideoDeviceCharacteristic
	{
		AllStreamsIndependent,
		PreviewRecordStreamsIdentical,
		PreviewPhotoStreamsIdentical,
		RecordPhotoStreamsIdentical,
		AllStreamsIdentical
	}
}
