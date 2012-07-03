using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Data.Xml.Dom
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IXmlDocumentStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class XmlDocument : IXmlDocument, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer, IXmlDocumentIO
	{
		public extern XmlDocumentType Doctype
		{
			get;
		}
		public extern XmlElement DocumentElement
		{
			get;
		}
		public extern string DocumentUri
		{
			get;
		}
		public extern XmlDomImplementation Implementation
		{
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
		public extern XmlDocument();
		public extern XmlElement CreateElement([In] string tagName);
		public extern XmlDocumentFragment CreateDocumentFragment();
		public extern XmlText CreateTextNode([In] string data);
		public extern XmlComment CreateComment([In] string data);
		public extern XmlProcessingInstruction CreateProcessingInstruction([In] string target, [In] string data);
		public extern XmlAttribute CreateAttribute([In] string name);
		public extern XmlEntityReference CreateEntityReference([In] string name);
		public extern XmlNodeList GetElementsByTagName([In] string tagName);
		public extern XmlCDataSection CreateCDataSection([In] string data);
		public extern XmlAttribute CreateAttributeNS([Variant] [In] object namespaceUri, [In] string qualifiedName);
		public extern XmlElement CreateElementNS([Variant] [In] object namespaceUri, [In] string qualifiedName);
		public extern XmlElement GetElementById([In] string elementId);
		public extern IXmlNode ImportNode([In] IXmlNode node, [In] bool deep);
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
		[Overload("LoadXml")]
		public extern void LoadXml([In] string xml);
		[Overload("LoadXmlWithSettings")]
		public extern void LoadXml([In] string xml, [In] XmlLoadSettings loadSettings);
		public extern IAsyncAction SaveToFileAsync([In] IStorageFile file);
		[Overload("LoadFromUriAsync")]
		public static extern IAsyncOperation<XmlDocument> LoadFromUriAsync([In] Uri uri);
		[Overload("LoadFromUriWithSettingsAsync")]
		public static extern IAsyncOperation<XmlDocument> LoadFromUriAsync([In] Uri uri, [In] XmlLoadSettings loadSettings);
		[Overload("LoadFromFileAsync")]
		public static extern IAsyncOperation<XmlDocument> LoadFromFileAsync([In] IStorageFile file);
		[Overload("LoadFromFileWithSettingsAsync")]
		public static extern IAsyncOperation<XmlDocument> LoadFromFileAsync([In] IStorageFile file, [In] XmlLoadSettings loadSettings);
	}
}
