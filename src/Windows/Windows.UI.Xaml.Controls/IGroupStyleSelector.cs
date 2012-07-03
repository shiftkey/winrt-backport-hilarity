using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(GroupStyleSelector)), Guid(1843007902u, 39540, 18319, 163, 57, 91, 181, 45, 230, 197, 30), Version(100794368u), WebHostHidden]
	internal interface IGroupStyleSelector
	{
		GroupStyle SelectGroupStyle([In] object group, [In] uint level);
	}
}
