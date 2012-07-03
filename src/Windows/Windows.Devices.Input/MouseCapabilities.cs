using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class MouseCapabilities : IMouseCapabilities
	{
		public extern int HorizontalWheelPresent
		{
			get;
		}
		public extern int MousePresent
		{
			get;
		}
		public extern uint NumberOfButtons
		{
			get;
		}
		public extern int SwapButtons
		{
			get;
		}
		public extern int VerticalWheelPresent
		{
			get;
		}
		public extern MouseCapabilities();
	}
}
