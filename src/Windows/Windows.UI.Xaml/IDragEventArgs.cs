using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DragEventArgs)), Guid(3024144323u, 692, 18816, 147, 66, 37, 218, 225, 192, 241, 136), Version(100794368u), WebHostHidden]
	internal interface IDragEventArgs
	{
		DataPackage Data
		{
			get;
			set;
		}
		bool Handled
		{
			get;
			set;
		}
		Point GetPosition([In] UIElement relativeTo);
	}
}
