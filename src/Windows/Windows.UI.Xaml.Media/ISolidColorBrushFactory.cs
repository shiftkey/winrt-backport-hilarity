using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(SolidColorBrush)), Guid(3644182028u, 34549, 19878, 138, 39, 177, 97, 158, 247, 249, 43), Version(100794368u), WebHostHidden]
	internal interface ISolidColorBrushFactory
	{
		SolidColorBrush CreateInstanceWithColor([In] Color color);
	}
}
