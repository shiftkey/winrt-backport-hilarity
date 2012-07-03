using System;
using Windows.Devices.Input;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Pointer : IPointer
	{
		public extern bool IsInContact
		{
			get;
		}
		public extern bool IsInRange
		{
			get;
		}
		public extern PointerDeviceType PointerDeviceType
		{
			get;
		}
		public extern uint PointerId
		{
			get;
		}
	}
}
