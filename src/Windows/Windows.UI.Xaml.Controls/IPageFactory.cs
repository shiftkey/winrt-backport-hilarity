using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Page)), Guid(3751889324u, 6217, 17502, 147, 124, 64, 169, 89, 12, 192, 118), Version(100794368u), WebHostHidden]
	internal interface IPageFactory
	{
		Page CreateInstance([In] object outer, out object inner);
	}
}
