using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class KeypadPressedEventArgs : IKeypadPressedEventArgs
	{
		public extern TelephonyKey TelephonyKey
		{
			get;
		}
	}
}
