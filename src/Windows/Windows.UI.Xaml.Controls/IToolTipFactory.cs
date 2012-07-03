using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ToolTip)), Guid(2307101699u, 46392, 18915, 164, 48, 58, 192, 55, 220, 111, 224), Version(100794368u), WebHostHidden]
	internal interface IToolTipFactory
	{
		ToolTip CreateInstance([In] object outer, out object inner);
	}
}
