using System;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class ManipulationStartedEventArgs : IManipulationStartedEventArgs
	{
		public extern ManipulationDelta Cumulative
		{
			get;
		}
		public extern PointerDeviceType PointerDeviceType
		{
			get;
		}
		public extern Point Position
		{
			get;
		}
	}
}
