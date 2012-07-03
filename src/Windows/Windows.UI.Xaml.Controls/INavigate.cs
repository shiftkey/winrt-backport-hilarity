using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Controls
{
	[Guid(3206649257u, 62698, 17206, 151, 124, 248, 252, 247, 139, 13, 158), Version(100794368u), WebHostHidden]
	public interface INavigate
	{
		bool Navigate([In] TypeName sourcePageType);
	}
}
