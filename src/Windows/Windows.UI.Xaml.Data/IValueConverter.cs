using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Data
{
	[Guid(3874684656u, 1810, 18559, 179, 19, 243, 0, 184, 215, 154, 161), Version(100794368u), WebHostHidden]
	public interface IValueConverter
	{
		object Convert([In] object value, [In] TypeName targetType, [In] object parameter, [In] string language);
		object ConvertBack([In] object value, [In] TypeName targetType, [In] object parameter, [In] string language);
	}
}
