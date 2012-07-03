using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[Guid(477371737u, 8482, 18389, 168, 86, 131, 243, 212, 33, 72, 117), Version(100794368u)]
	public interface IXmlNode : IXmlNodeSelector, IXmlNodeSerializer
	{
		XmlNamedNodeMap Attributes
		{
			get;
		}
		XmlNodeList ChildNodes
		{
			get;
		}
		IXmlNode FirstChild
		{
			get;
		}
		IXmlNode LastChild
		{
			get;
		}
		object LocalName
		{
			[return: Variant]
			get;
		}
		object NamespaceUri
		{
			[return: Variant]
			get;
		}
		IXmlNode NextSibling
		{
			get;
		}
		string NodeName
		{
			get;
		}
		NodeType NodeType
		{
			get;
		}
		object NodeValue
		{
			[return: Variant]
			get;
			[param: Variant]
			set;
		}
		XmlDocument OwnerDocument
		{
			get;
		}
		IXmlNode ParentNode
		{
			get;
		}
		object Prefix
		{
			[return: Variant]
			get;
			[param: Variant]
			set;
		}
		IXmlNode PreviousSibling
		{
			get;
		}
		bool HasChildNodes();
		IXmlNode InsertBefore([In] IXmlNode newChild, [In] IXmlNode referenceChild);
		IXmlNode ReplaceChild([In] IXmlNode newChild, [In] IXmlNode referenceChild);
		IXmlNode RemoveChild([In] IXmlNode childNode);
		IXmlNode AppendChild([In] IXmlNode newChild);
		IXmlNode CloneNode([In] bool deep);
		void Normalize();
	}
}
