using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(TextBox)), Guid(1896759928u, 34089, 18387, 141, 142, 48, 126, 52, 207, 240, 129), Version(100794368u), WebHostHidden]
	internal interface ITextBoxFactory
	{
		TextBox CreateInstance([In] object outer, out object inner);
	}
}
