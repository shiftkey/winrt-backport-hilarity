using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(FrameworkTemplate)), Guid(444113061u, 37757, 18132, 131, 43, 148, 255, 20, 218, 176, 97), Version(100794368u), WebHostHidden]
	internal interface IFrameworkTemplateFactory
	{
		FrameworkTemplate CreateInstance([In] object outer, out object inner);
	}
}
