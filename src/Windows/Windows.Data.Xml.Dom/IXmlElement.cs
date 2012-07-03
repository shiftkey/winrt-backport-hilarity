using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlElement)), Guid(771459615u, 27408, 20216, 159, 131, 239, 204, 232, 250, 236, 55), Version(100794368u)]
	internal interface IXmlElement : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		string TagName
		{
			get;
		}
		string GetAttribute([In] string attributeName);
		void SetAttribute([In] string attributeName, [In] string attributeValue);
		void RemoveAttribute([In] string attributeName);
		XmlAttribute GetAttributeNode([In] string attributeName);
		XmlAttribute SetAttributeNode([In] XmlAttribute newAttribute);
		XmlAttribute RemoveAttributeNode([In] XmlAttribute attributeNode);
		XmlNodeList GetElementsByTagName([In] string tagName);
		void SetAttributeNS([Variant] [In] object namespaceUri, [In] string qualifiedName, [In] string value);
		string GetAttributeNS([Variant] [In] object namespaceUri, [In] string localName);
		void RemoveAttributeNS([Variant] [In] object namespaceUri, [In] string localName);
		XmlAttribute SetAttributeNodeNS([In] XmlAttribute newAttribute);
		XmlAttribute GetAttributeNodeNS([Variant] [In] object namespaceUri, [In] string localName);
	}
}
