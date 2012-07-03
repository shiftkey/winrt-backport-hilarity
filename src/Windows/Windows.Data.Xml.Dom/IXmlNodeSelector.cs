using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[Guid(1675344523u, 53467, 20449, 183, 69, 249, 67, 58, 253, 194, 91), Version(100794368u)]
	public interface IXmlNodeSelector
	{
		IXmlNode SelectSingleNode([In] string xpath);
		XmlNodeList SelectNodes([In] string xpath);
		IXmlNode SelectSingleNodeNS([In] string xpath, [Variant] [In] object namespaces);
		XmlNodeList SelectNodesNS([In] string xpath, [Variant] [In] object namespaces);
	}
}
