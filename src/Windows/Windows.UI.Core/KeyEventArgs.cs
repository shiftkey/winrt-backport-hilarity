using System;
using Windows.Foundation.Metadata;
using Windows.System;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class KeyEventArgs : IKeyEventArgs, ICoreWindowEventArgs
	{
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
