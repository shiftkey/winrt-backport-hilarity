using System;
using Windows.Foundation.Metadata;
using Windows.System;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(AcceleratorKeyEventArgs)), Guid(4280044618u, 37511, 18187, 131, 110, 144, 134, 227, 18, 106, 222), Version(100794368u), WebHostHidden]
	internal interface IAcceleratorKeyEventArgs : ICoreWindowEventArgs
	{
		CoreAcceleratorKeyEventType EventType
		{
			get;
		}
		CorePhysicalKeyStatus KeyStatus
		{
			get;
		}
		VirtualKey VirtualKey
		{
			get;
		}
	}
}
