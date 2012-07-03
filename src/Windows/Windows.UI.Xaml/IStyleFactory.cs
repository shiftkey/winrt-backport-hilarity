using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Style)), Guid(2741511395u, 15745, 19685, 170, 81, 139, 65, 15, 96, 47, 205), Version(100794368u), WebHostHidden]
	internal interface IStyleFactory
	{
		Style CreateInstance([In] TypeName targetType);
	}
}
