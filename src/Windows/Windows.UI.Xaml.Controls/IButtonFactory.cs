using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Button)), Guid(2158050329u, 33850, 17692, 140, 245, 68, 199, 1, 176, 226, 22), Version(100794368u), WebHostHidden]
	internal interface IButtonFactory
	{
		Button CreateInstance([In] object outer, out object inner);
	}
}
