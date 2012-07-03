using System;
using Windows.Foundation.Metadata;
using Windows.System;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(KeyEventArgs)), Guid(1609951536u, 9540, 18967, 189, 120, 31, 47, 222, 187, 16, 107), Version(100794368u), WebHostHidden]
	internal interface IKeyEventArgs : ICoreWindowEventArgs
	{
		CorePhysicalKeyStatus KeyStatus
		{
			get;
		}
		VirtualKey VirtualKey
		{
			get;
		}
	}
}
