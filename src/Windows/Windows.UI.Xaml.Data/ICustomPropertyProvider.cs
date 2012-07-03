using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Data
{
	[Guid(2089965397u, 15944, 17076, 134, 119, 118, 55, 34, 103, 3, 63), Version(100794368u)]
	public interface ICustomPropertyProvider
	{
		TypeName Type
		{
			get;
		}
		ICustomProperty GetCustomProperty([In] string name);
		ICustomProperty GetIndexedProperty([In] string name, [In] TypeName type);
		string GetStringRepresentation();
	}
}
