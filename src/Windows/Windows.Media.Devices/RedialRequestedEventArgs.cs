using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class RedialRequestedEventArgs : IRedialRequestedEventArgs
	{
		public extern void Handled();
	}
}
