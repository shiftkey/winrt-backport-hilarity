using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(WindowSizeChangedEventArgs)), Guid(1512050375u, 1062, 18396, 184, 108, 111, 71, 89, 21, 228, 81), Version(100794368u), WebHostHidden]
	internal interface IWindowSizeChangedEventArgs : ICoreWindowEventArgs
	{
		Size Size
		{
			get;
		}
	}
}
