using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Window)), Guid(2469561353u, 20129, 19194, 131, 220, 12, 78, 115, 232, 139, 177), Version(100794368u), WebHostHidden]
	internal interface IWindowStatics
	{
		Window Current
		{
			get;
		}
	}
}
