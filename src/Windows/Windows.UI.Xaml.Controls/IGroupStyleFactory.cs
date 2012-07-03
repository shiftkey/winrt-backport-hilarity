using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(GroupStyle)), Guid(1459578447u, 58071, 20297, 128, 61, 199, 39, 205, 249, 55, 45), Version(100794368u), WebHostHidden]
	internal interface IGroupStyleFactory
	{
		GroupStyle CreateInstance([In] object outer, out object inner);
	}
}
