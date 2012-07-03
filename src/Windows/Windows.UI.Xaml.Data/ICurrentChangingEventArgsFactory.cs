using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(CurrentChangingEventArgs)), Guid(356237038u, 25331, 18639, 129, 131, 139, 226, 109, 227, 166, 110), Version(100794368u), WebHostHidden]
	internal interface ICurrentChangingEventArgsFactory
	{
		CurrentChangingEventArgs CreateInstance([In] object outer, out object inner);
		CurrentChangingEventArgs CreateWithCancelableParameter([In] bool isCancelable, [In] object outer, out object inner);
	}
}
