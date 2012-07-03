using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(RelativeSource)), Guid(4018377421u, 17518, 20371, 170, 203, 155, 18, 85, 87, 116, 96), Version(100794368u), WebHostHidden]
	internal interface IRelativeSourceFactory
	{
		RelativeSource CreateInstance([In] object outer, out object inner);
	}
}
