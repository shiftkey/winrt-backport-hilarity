using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Input
{
	[ExclusiveTo(typeof(KeyboardCapabilities)), Guid(977247062u, 26520, 19388, 131, 62, 15, 52, 177, 124, 101, 255), Version(100794368u)]
	internal interface IKeyboardCapabilities
	{
		int KeyboardPresent
		{
			get;
		}
	}
}
