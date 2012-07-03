using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(VisualStateManager)), Guid(2246416637u, 42357, 18358, 158, 48, 56, 60, 208, 133, 133, 242), Version(100794368u), WebHostHidden]
	internal interface IVisualStateManagerFactory
	{
		VisualStateManager CreateInstance([In] object outer, out object inner);
	}
}
