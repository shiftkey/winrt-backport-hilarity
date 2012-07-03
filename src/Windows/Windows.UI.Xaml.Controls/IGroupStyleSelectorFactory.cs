using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(GroupStyleSelector)), Guid(3210153267u, 45814, 18463, 164, 80, 200, 12, 41, 31, 178, 45), Version(100794368u), WebHostHidden]
	internal interface IGroupStyleSelectorFactory
	{
		GroupStyleSelector CreateInstance([In] object outer, out object inner);
	}
}
