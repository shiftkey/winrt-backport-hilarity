using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[Guid(3862406228u, 50471, 16940, 137, 38, 201, 175, 131, 181, 89, 160), Version(100794368u)]
	public delegate void KeypadPressedEventHandler([In] CallControl sender, [In] KeypadPressedEventArgs e);
}
