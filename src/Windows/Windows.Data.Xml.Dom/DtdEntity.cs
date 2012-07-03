using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DtdEntity : IDtdEntity, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		public extern object NotationName
		{
			[return: Variant]
			get;
		}
		public extern object PublicId
		{
			[return: Variant]
			get;
		}
		public extern object SystemId
		{
			[return: Variant]
			get;
		}
		public extern XmlNamedNodeMap Attributes
		{
			get;
		}
		public extern XmlNodeList ChildNodes
		{
			get;
		}
		public extern IXmlNode FirstChild
		{
			get;
		}
		public extern IXmlNode LastChild
		{
			get;
		}
		public extern object LocalName
		{
			[return: Variant]
			get;
		}
		public extern object NamespaceUri
		{
			[return: Variant]
			get;
		}
		public extern IXmlNode NextSibling
		{
			get;
		}
		public extern string NodeName
		{
			get;
		}
		public extern NodeType NodeType
		{
			get;
		}
		public extern object NodeValue
		{
			[return: Variant]
			get;
			[param: Variant]
			set;
		}
		public extern XmlDocument OwnerDocument
		{
			get;
		}
		public extern IXmlNode ParentNode
		{
			get;
		}
		public extern object Prefix
		{
			[return: Variant]
			get;
			[param: Variant]
			set;
		}
		public extern IXmlNode PreviousSibling
		{
			get;
		}
		public extern string InnerText
		{
			get;
			set;
		}
		public extern bool HasChildNodes();
		public extern IXmlNode InsertBefore([In] IXmlNode newChild, [In] IXmlNode referenceChild);
		public extern IXmlNode ReplaceChild([In] IXmlNode newChild, [In] IXmlNode referenceChild);
		public extern IXmlNode RemoveChild([In] IXmlNode childNode);
		public extern IXmlNode AppendChild([In] IXmlNode newChild);
		public extern IXmlNode CloneNode([In] bool deep);
		public extern void Normalize();
		public extern IXmlNode SelectSingleNode([In] string xpath);
		public extern XmlNodeList SelectNodes([In] string xpath);
		public extern IXmlNode SelectSingleNodeNS([In] string xpath, [Variant] [In] object namespaces);
		public extern XmlNodeList SelectNodesNS([In] string xpath, [Variant] [In] object namespaces);
		public extern string GetXml();
	}
}
