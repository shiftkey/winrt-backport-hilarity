using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(KeypadPressedEventArgs)), Guid(3550755072u, 46330, 18893, 148, 66, 137, 175, 101, 104, 246, 1), Version(100794368u)]
	internal interface IKeypadPressedEventArgs
	{
		TelephonyKey TelephonyKey
		{
			get;
		}
	}
}
