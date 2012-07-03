using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(Projection)), Guid(3304234155u, 24749, 20260, 189, 39, 157, 105, 195, 18, 124, 154), Version(100794368u), WebHostHidden]
	internal interface IProjectionFactory
	{
		Projection CreateInstance([In] object outer, out object inner);
	}
}
