using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ListView)), Guid(3187632493u, 16162, 16889, 151, 166, 136, 49, 52, 167, 97, 19), Version(100794368u), WebHostHidden]
	internal interface IListViewFactory
	{
		ListView CreateInstance([In] object outer, out object inner);
	}
}
