using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(AppBar)), Guid(1632045265u, 36453, 17355, 146, 215, 142, 238, 23, 81, 95, 141), Version(100794368u), WebHostHidden]
	internal interface IAppBarFactory
	{
		AppBar CreateInstance([In] object outer, out object inner);
	}
}
