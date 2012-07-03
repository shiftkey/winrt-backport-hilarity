using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DialRequestedEventArgs : IDialRequestedEventArgs
	{
		public extern object Contact
		{
			get;
		}
		public extern void Handled();
	}
}
