using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Interop
{
	[Guid(960358366u, 28624, 19469, 187, 113, 71, 36, 74, 17, 62, 147), Version(100794368u), WebHostHidden]
	public interface IBindableVector : IBindableIterable
	{
		uint Size
		{
			get;
		}
		object GetAt([In] uint index);
		IBindableVectorView GetView();
		bool IndexOf([In] object value, out uint index);
		void SetAt([In] uint index, [In] object value);
		void InsertAt([In] uint index, [In] object value);
		void RemoveAt([In] uint index);
		void Append([In] object value);
		void RemoveAtEnd();
		void Clear();
	}
}
