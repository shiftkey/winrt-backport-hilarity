using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[MarshalingBehavior(MarshalingType.None), Static(typeof(IPointerDeviceStatics), 100794368u), Version(100794368u)]
	public sealed class PointerDevice : IPointerDevice
	{
		public extern bool IsIntegrated
		{
			get;
		}
		public extern uint MaxContacts
		{
			get;
		}
		public extern Rect PhysicalDeviceRect
		{
			get;
		}
		public extern PointerDeviceType PointerDeviceType
		{
			get;
		}
		public extern Rect ScreenRect
		{
			get;
		}
		public extern IVectorView<PointerDeviceUsage> SupportedUsages
		{
			get;
		}
		public static extern PointerDevice GetPointerDevice([In] uint pointerId);
		public static extern IVectorView<PointerDevice> GetPointerDevices();
	}
}
