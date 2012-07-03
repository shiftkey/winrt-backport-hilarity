using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Interop
{
	[Guid(1649202401u, 53255, 17329, 156, 3, 175, 77, 62, 98, 88, 196), Version(100794368u), WebHostHidden]
	public delegate void BindableVectorChangedEventHandler([In] IBindableObservableVector vector, [In] object e);
}
