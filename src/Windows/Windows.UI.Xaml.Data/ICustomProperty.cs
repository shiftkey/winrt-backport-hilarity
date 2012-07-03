using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Data
{
	[Guid(819630784u, 9192, 17056, 174, 124, 115, 74, 14, 93, 39, 130), Version(100794368u)]
	public interface ICustomProperty
	{
		bool CanRead
		{
			get;
		}
		bool CanWrite
		{
			get;
		}
		string Name
		{
			get;
		}
		TypeName Type
		{
			get;
		}
		object GetValue([In] object target);
		void SetValue([In] object target, [In] object value);
		object GetIndexedValue([In] object target, [In] object index);
		void SetIndexedValue([In] object target, [In] object value, [In] object index);
	}
}
