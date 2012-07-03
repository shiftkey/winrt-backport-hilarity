using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlNamedNodeMap)), Guid(3014041264u, 43696, 19330, 166, 250, 177, 69, 63, 124, 2, 27), Version(100794368u)]
	internal interface IXmlNamedNodeMap : IVectorView<IXmlNode>, IIterable<IXmlNode>
	{
		uint Length
		{
			get;
		}
		IXmlNode Item([In] uint index);
		IXmlNode GetNamedItem([In] string name);
		IXmlNode SetNamedItem([In] IXmlNode node);
		IXmlNode RemoveNamedItem([In] string name);
		IXmlNode GetNamedItemNS([Variant] [In] object namespaceUri, [In] string name);
		IXmlNode RemoveNamedItemNS([Variant] [In] object namespaceUri, [In] string name);
		IXmlNode SetNamedItemNS([In] IXmlNode node);
	}
}
