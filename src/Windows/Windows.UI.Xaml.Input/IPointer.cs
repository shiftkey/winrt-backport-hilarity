using System;
using Windows.Devices.Input;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(Pointer)), Guid(1592325023u, 29821, 16753, 144, 230, 205, 55, 169, 223, 251, 17), Version(100794368u), WebHostHidden]
	internal interface IPointer
	{
		bool IsInContact
		{
			get;
		}
		bool IsInRange
		{
			get;
		}
		PointerDeviceType PointerDeviceType
		{
			get;
		}
		uint PointerId
		{
			get;
		}
	}
}
