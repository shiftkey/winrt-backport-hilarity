using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(GroupStyleSelector)), Guid(4136749746u, 30637, 19773, 165, 28, 142, 249, 195, 131, 100, 86), Version(100794368u), WebHostHidden]
	internal interface IGroupStyleSelectorOverrides
	{
		GroupStyle SelectGroupStyleCore([In] object group, [In] uint level);
	}
}
