using System;
using Windows.Foundation.Metadata;
using Windows.System;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u), WebHostHidden]
	public sealed class AcceleratorKeyEventArgs : IAcceleratorKeyEventArgs, ICoreWindowEventArgs
	{
		public extern CoreAcceleratorKeyEventType EventType
		{
			get;
		}
		public extern CorePhysicalKeyStatus KeyStatus
		{
			get;
		}
		public extern VirtualKey VirtualKey
		{
			get;
		}
		public extern bool Handled
		{
			get;
			set;
		}
	}
}
