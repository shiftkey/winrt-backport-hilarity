using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[Version(100794368u)]
	public enum SimpleOrientation
	{
		NotRotated,
		Rotated90DegreesCounterclockwise,
		Rotated180DegreesCounterclockwise,
		Rotated270DegreesCounterclockwise,
		Faceup,
		Facedown
	}
}
