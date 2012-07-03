using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Interop
{
	[Guid(879613671u, 38766, 19395, 129, 93, 236, 226, 67, 188, 15, 51), Version(100794368u), WebHostHidden]
	public interface IBindableVectorView : IBindableIterable
	{
		uint Size
		{
			get;
		}
		object GetAt([In] uint index);
		bool IndexOf([In] object value, out uint index);
	}
}
