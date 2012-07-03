using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Path)), Guid(591439075u, 23174, 20422, 154, 80, 203, 185, 59, 130, 135, 102), Version(100794368u), WebHostHidden]
	internal interface IPathFactory
	{
		Path CreateInstance([In] object outer, out object inner);
	}
}
