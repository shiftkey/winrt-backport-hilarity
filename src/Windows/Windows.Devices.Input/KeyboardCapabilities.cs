using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class KeyboardCapabilities : IKeyboardCapabilities
	{
		public extern int KeyboardPresent
		{
			get;
		}
		public extern KeyboardCapabilities();
	}
}
