using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(RedialRequestedEventArgs)), Guid(2125812233u, 30379, 19505, 180, 14, 75, 88, 55, 157, 88, 12), Version(100794368u)]
	internal interface IRedialRequestedEventArgs
	{
		void Handled();
	}
}
