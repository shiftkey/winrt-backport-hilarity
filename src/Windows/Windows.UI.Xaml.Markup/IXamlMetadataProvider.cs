using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Markup
{
	[Guid(3010878825u, 26789, 19250, 136, 97, 253, 185, 12, 31, 88, 54), Version(100794368u), WebHostHidden]
	public interface IXamlMetadataProvider
	{
		[DefaultOverload, Overload("GetXamlType")]
		IXamlType GetXamlType([In] TypeName type);
		[Overload("GetXamlTypeByFullName")]
		IXamlType GetXamlType([In] string fullName);
		XmlnsDefinition[] GetXmlnsDefinitions();
	}
}
