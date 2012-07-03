using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Canvas)), Guid(456297425u, 46080, 19086, 148, 59, 90, 210, 196, 91, 224, 223), Version(100794368u), WebHostHidden]
	internal interface ICanvasFactory
	{
		Canvas CreateInstance([In] object outer, out object inner);
	}
}
