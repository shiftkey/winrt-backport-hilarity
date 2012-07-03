using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class TouchCapabilities : ITouchCapabilities
	{
		public extern uint Contacts
		{
			get;
		}
		public extern int TouchPresent
		{
			get;
		}
		public extern TouchCapabilities();
	}
}
