using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(GroupItem)), Guid(3651261758u, 45536, 17177, 152, 8, 122, 158, 136, 126, 19, 176), Version(100794368u), WebHostHidden]
	internal interface IGroupItemFactory
	{
		GroupItem CreateInstance([In] object outer, out object inner);
	}
}
