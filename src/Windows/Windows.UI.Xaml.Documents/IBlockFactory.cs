using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Block)), Guid(118555954u, 20313, 20283, 156, 229, 37, 120, 76, 67, 5, 7), Version(100794368u), WebHostHidden]
	internal interface IBlockFactory
	{
		Block CreateInstance([In] object outer, out object inner);
	}
}
