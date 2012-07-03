using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Frame)), Guid(49189844u, 17550, 18078, 151, 153, 10, 138, 31, 112, 241, 113), Version(100794368u), WebHostHidden]
	internal interface IFrameFactory
	{
		Frame CreateInstance([In] object outer, out object inner);
	}
}
