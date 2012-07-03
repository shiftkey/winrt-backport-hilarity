using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(GridView)), Guid(3653028489u, 2553, 19566, 168, 62, 241, 153, 20, 111, 14, 125), Version(100794368u), WebHostHidden]
	internal interface IGridViewFactory
	{
		GridView CreateInstance([In] object outer, out object inner);
	}
}
