using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CoreWindowDialog)), Guid(3484592213u, 7257, 19219, 177, 229, 22, 226, 152, 5, 247, 196), Version(100794368u), WebHostHidden]
	internal interface ICoreWindowDialogFactory
	{
		CoreWindowDialog CreateWithTitle([In] string title);
	}
}
